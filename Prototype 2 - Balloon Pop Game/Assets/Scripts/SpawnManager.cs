using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPrefabs;
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;

    // public int balloonIndex;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);
    }

    void SpawnRandomBalloon()
    {
       Vector3 spawnPos = new Vector3(Random.Range(-437,437),190,0);
       //Pick a random Balloon from the Baloon Array
       int balloonIndex = Random.Range(0,balloonPrefabs.Length);
       // Spawn random balloon at spawn position 
       Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex].transform.rotation); 
    }
}
