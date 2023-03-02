using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{

   [Serializable]
   public struct SpawnData
   {
       public GameObject obstacle_top;
       public GameObject obstacle_bottom;
       
   }


    public GameObject[] test;
    
    public  SpawnData[] pattern;

   

    private int patternIndex = 0;

    //public float speed =0;
    
    /*public float maxX;
    public float minX;
    public float maxY;
    public float minY;*/

    private float spawnTime;
    // Start is called before the first frame update
   

    
   
    

    // Update is called once per frame
    void Update()
    {
         float timeBetweenSpawn = 5;
       

                if(Time.time > spawnTime)
            {
                Spawn();
            
                spawnTime= Time.time + timeBetweenSpawn;
                Debug.Log("Item spawned");
                
            }

        
        
    }

    void Spawn()
    {
        SpawnData data = pattern[patternIndex];
        //float randomX = Random.Range(minX, maxX);
        //float randomY = Random.Range(minY, maxY);

        Instantiate(data.obstacle_top, transform.position + new Vector3(29, 2, 0), transform.rotation);
        Instantiate(data.obstacle_bottom, transform.position + new Vector3(29, -2, 0), transform.rotation);
    }
}
