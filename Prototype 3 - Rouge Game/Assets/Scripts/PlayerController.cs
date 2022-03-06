using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; //Speed at which the player will move
    private Rigidbody2D rb; // Store the referecned 2D RigidBody 

    Vector2 movement; //Store the platerts x,y postion for movement 

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
    }
    // Set Number of Calls per Frame 
    void FixedUpdate()
    {
        //Apply Physics and move the character 
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }
}   
    

