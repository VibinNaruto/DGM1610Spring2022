using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    // public string[] friendNames = {"Bob", "Jessica", "Jody", "Arthur", "Randall", "Todd", "Chris"}; Array # 1

    // public string[] narutoNames = {"Naruto", "Kakashi", "Sasuke", "Sakura", "Hinata", "Guy"}; Array # 2

    // public string[] gamecharacters ={"Aloy", "Kratos", "Nathan Drake", "Jin", "Ellie", "Joel"}; Array # 3

     public int[] doublenumbers = {11,22,33,44,55,66,77}; //Array # 4

    // public int[] numbers = {23,46,77,10,42,98,63,81}; Array # 5 
    //                     {0, 1, 2, 3, 4, 5, 6}

    // Start is called before the first frame update
    void Start()
    {
        /* // Code with Array # 3 - #6 
        Debug.Log("Old Best PSN Character" + gamecharacters);
        Debug.Log(gamecharacters[3]+"Says infamous quote!");
        gamecharacters[0] ="Spider-Man";
        Debug.Log("New Best PSN Character" + gamecharacters);
        */

        /* // Code with Array # 2 - #7
        Debug.Log("Former Ninja Friend" + narutoNames);
        Debug.Log(narutoNames[3]+" Believe it!");
        narutoNames[0] ="Choji";
        Debug.Log("New to the Hidden Leaf Villige" + narutoNames);
        */

        /* // Code with Array # 1 - #8
        Debug.Log("Former friend" + friendNames[0]);
        Debug.Log(friendNames[3]+" Says Hi while he walks to class");
        friendNameS[0] = "Veronica";
        Debug.Log("New Friend" + friendNames[0]);
        */

        /* // Code of foreach with Array # 5 - #9
        foreach(int numbers in numbers)
        {
            print(numbers);
        }
        */
            // Code of foreach with Array # 4 - #10
        foreach(int doublenumbers in doublenumbers)
        {
            print(doublenumbers);
        }
    }
}
