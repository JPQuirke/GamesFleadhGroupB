using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;


public class SpawnObstacles : MonoBehaviour
{




    public GameObject[] obstacle_top;
    public GameObject[] obstacle_bottom;
    GameObject topob;
    GameObject bottomob;
    int index;
    int index2;

    public float spawnRate = 10.0f;
    private float nextSpawn = 0.0f;

    
  
    // used to declare the amount of score that is increased per seconed



   
    
    

    //public float speed =0;
    
    /*public float maxX;
    public float minX;
    public float maxY;
    public float minY;*/

  
    
   
    

    // Update is called once per frame
    void Update()
    {

         //obstacle_top = GameObject.FindGameObjectsWithTag("point");
         
        
         //spawnTime = 5;
       
        
            
            
            
                if(Time.time > nextSpawn)
            {

                index = Random.Range (0, obstacle_top.Length);
                topob = obstacle_top[index];

                index2 = Random.Range (0, obstacle_bottom.Length);
                bottomob = obstacle_bottom[index];
                
                Instantiate(topob, transform.position + new Vector3(29, 2, 0), transform.rotation);
                Instantiate(bottomob, transform.position + new Vector3(29, -2, 0), transform.rotation);
                //scoreTotal += scoreIncreasePerSecond * Time.deltaTime;
            
                
                Debug.Log("Item spawned");
              nextSpawn = Time.time + spawnRate;
                  
                  
            }

            

        
        
    }

 
}
