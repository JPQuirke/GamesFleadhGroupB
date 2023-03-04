﻿
using System;
using System.Collections;

using UnityEngine;

public class WaypointPatternMovement : MonoBehaviour
{
   [Serializable]
   public struct WaypointData
   {
       public GameObject location;
       public int speed;
     
   }
    // int for chase range
    int chaseRange =120;
    public WaypointData[] pattern;

    private int patternIndex = 0;

    public float speed =0;
    
     public  float timeBetween = 100f;

    private bool paused = false;

    // Use this for initialization
    void Start ()
    {
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(paused)
        {
            return;
        } 
      
         // Process the current instruction in our control data array
        WaypointData data = pattern[patternIndex];
        speed = data.speed; 

     

        // Find the range to close vector
        Vector3 rangeToClose = data.location.transform.position - transform.position;

        // Draw this vector at the position of the enemy
        Debug.DrawRay(transform.position, rangeToClose, Color.cyan);

        // What's our distance to the waypoint?
        float distance = rangeToClose.magnitude;
        // checks to see if the object distance is greater then the chase range and if so the object will pause
        if(distance > chaseRange)
         {
                StartCoroutine(PauseEnemy(timeBetween));
         }
        // How far do we move each frame
        float speedDelta = speed * Time.deltaTime;

        // If we're close enough to the current waypoint 
        // then increase the pattern index
       
            if (distance <= speedDelta)
            {
                        
                patternIndex++;
                        
                // Reset the patternIndex if we are at the end of the instruction array
              if (patternIndex >= pattern.Length)
             {
                         patternIndex = 0;
             }

             

               // Process the current instruction in our control data array
                data = pattern[patternIndex];
                speed = data.speed;
                // Find the new range to close vector
                rangeToClose = data.location.transform.position - transform.position;
              

                       
            }   
        

        // In what direction is our waypoint?
        Vector3 normalizedRangeToClose = rangeToClose.normalized;

        // Draw this vector at the position of the waypoint
        Debug.DrawRay(transform.position, normalizedRangeToClose, Color.magenta);

        Vector3 delta = speedDelta * normalizedRangeToClose;

        transform.Translate(delta);
        
       
      
    } 

    IEnumerator PauseEnemy(float waitTime)
    {
        paused = true;
        yield return  new WaitForSeconds (waitTime);
        paused = false;
    }
    
}
