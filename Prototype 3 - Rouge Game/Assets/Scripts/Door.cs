using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && playerController.keys == 1)
        {
            Debug.Log("You have opened the door");
            Destroy(gameObject);
        }
        else 
        {
            Debug.Log("Door  is Locked, you need a key");
        }
    }
}
