using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject obstacle; //reference to obstacle for spawning
    private Vector3 spawnPoint;

    
    // Start is called before the first frame update
    void Start()
    {  
        GameStart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO: Spawn obstacles at a certain point before it exits camera. Ensure 
    // random distances (range between some min distance that isn't too close too each other)
    // e.g; coord - (minDistance * rand(min, max)
    IEnumerator SpawnObstacles()
    {
        while (true)
        {
            // Spawn obstacles at certain times
            float waitTime = Random.Range(0.5f, 2f);
            yield return new WaitForSeconds(waitTime);
            // Create random spawnpoints
            spawnPoint = new Vector3(Random.Range(-1.5f, 2.5f), 0.5f, -0.050f);
            Instantiate(obstacle, spawnPoint, Quaternion.identity); 
            
        }
    }

    public void GameStart()
    {
        StartCoroutine("SpawnObstacles");
    }
}
