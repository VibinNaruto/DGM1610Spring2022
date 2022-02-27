using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive = 100;
    public int clickToPop = 3;
    public float scaleToIncrease = 0.10f;
    public ScoreManager scoreManger; 

    // Start is called before the first frame update
    void Start()
    {
        //Reference ScoreManager Component 
        scoreManger = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    void OnMouseDown()
    {
        // Reduce the clicks by one 
        clickToPop -= 1;
        // Increase
        transform.localScale += Vector3.one * scaleToIncrease;

        if(clickToPop == 0)
        {
            scoreManger.IncreaseScoreText(scoreToGive);
            Destroy(gameObject);
        }
    }
}
