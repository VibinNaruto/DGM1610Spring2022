using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public float lowerBound = 10.0f;

    public ScoreManager scoreManager; // A Variable to Reference the ScoreManger

    private Balloon balloon;

    // Start is called before the first frame update
    void Start()
    {
        // Reference ScoreManager Component 
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        balloon = GetComponent<Balloon>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move the Balloon Downward 
        transform.Translate(Vector3.down * Time.deltaTime);

        // Destroy Balloon after it passes lowerbound 
        if(transform.position.y < lowerBound)
        {
            scoreManager.DecreaseScoreText(balloon.scoreToGive);
            Destroy(gameObject);
        }
    }
}
