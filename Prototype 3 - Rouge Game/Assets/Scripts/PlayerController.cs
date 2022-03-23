using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header ("Player Health")]
    public int curHP;
    public int maxHP;

    
     [Header ("Player Movement")]
    public float moveSpeed = 5f; //Speed at which the player will move
    private Rigidbody2D rb; // Store the referecned 2D RigidBody 

    private Vector2 movement; //Store the platerts x,y postion for movement 
    private Vector2 direction;

    [Header("Player Combat")]
    public float attackRange; // Range at which the player can attack 
    public float attackRate;
    private float lastAttackTime;
    public int damage; // Damage amount dealt to enemy
    public LayerMask enemyLayer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); // Input for Left Right Movement
        movement.y = Input.GetAxis("Vertical"); // Input for up Down Movement

        if(Input.GetKeyDown(KeyCode.X))
        {
            if(Time.time - lastAttackTime >= attackRate)
                attack();
        }
    }
    // Set Number of Calls per Frame 
    void FixedUpdate()
    {
        //Apply Physics and move the character 
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

        UpdateDirection();
    }

    void UpdateDirection()
    {
        Vector2 vel = new Vector2(movement.x,movement.y);

        if(vel.magnitude != 0)
        {
            direction = vel;
        }

        rb.velocity = vel * moveSpeed;
        
    }

    void attack()
    {
        lastAttackTime = Time.time;
        // Raycast using the enemy Layer

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer);

        if(hit.collider != null)
        {
            hit.collider.GetComponent<Enemy>()?.TakeDamage(damage);
        }
    }
    public void TakeDamage(int damage)
    {
        curHP -= damage;
        
        if(curHP <= 0)
        {
            Die();
        }

    }


     void Die()
    {
        Debug.Log("Player has taken the L");
    }
}   
    

