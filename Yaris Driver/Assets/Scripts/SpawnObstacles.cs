using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random=UnityEngine.Random;


public class SpawnObstacles : MonoBehaviour
{



  //creating two arrays, one to represent the objects being spawned on the top bit of the road and the other for the bottom bit
    public GameObject[] obstacle_top;
    public GameObject[] obstacle_bottom;
    //creating gameobjects to represent the objects being spawned
    GameObject topob;
    GameObject bottomob;
    //indexes being made for the arrays
    int index;
    int index2;
//float for the interval between spawn
    public float spawnRate = 10.0f;
    //when is the next spawn
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
       
        
            
            
            //if time is greater than the time for the next spawn run the spawner
                if(Time.time > nextSpawn)
            {
              //indexes being set to a random object within the array
                index = Random.Range (0, obstacle_top.Length);
                topob = obstacle_top[index];

                index2 = Random.Range (0, obstacle_bottom.Length);
                bottomob = obstacle_bottom[index];
                
                //instantiating the objects
                Instantiate(topob, transform.position + new Vector3(29, 2, 0), transform.rotation);
                Instantiate(bottomob, transform.position + new Vector3(29, -2, 0), transform.rotation);
                //scoreTotal += scoreIncreasePerSecond * Time.deltaTime;
            
                
                Debug.Log("Item spawned");
              nextSpawn = Time.time + spawnRate;
                  
                  
            }

            

        
        
    }

 
}
