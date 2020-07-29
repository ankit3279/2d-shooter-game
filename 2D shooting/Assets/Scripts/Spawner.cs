using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnPoint;
    private float timeBtnSpawn;
    public float stratTimeBtnSpawn;
  

    // Update is called once per frame
    void Update()
    {
        if(timeBtnSpawn<=0)
        {
            int rand = Random.Range(0, spawnPoint.Length - 1);
            Instantiate(enemy, spawnPoint[rand].position, Quaternion.identity);
            timeBtnSpawn = stratTimeBtnSpawn;
        }
        else
        {
            timeBtnSpawn -= Time.deltaTime;
        }
        
    }
}
