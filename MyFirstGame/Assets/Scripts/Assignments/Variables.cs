using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //Global Variables
    public int money = 12; // Variable Declaration 
    public float change = 0.75f; // Floating point number or decimal 3.15, 105.34, -299.87
    public bool isday = true; // Booleans are true or false
    public string loginame = "Jinx2345"; // string are alpha numeric text contained it quotation marks



    // Start is called before the first frame update
    void Start()
    {
        money = 125;
        Debug.Log("Money in account = $" + money);
       
    }

    // Update is called once per frame
    void Update()
    {
        if(loginame == "Jinx2345")
        {
            print("you have logged in");
        }
        else
        {
            Debug.Log("invalid login name");
        }
    }
}
