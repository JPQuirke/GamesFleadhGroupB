using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public GameObject target;
    public float speed;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speedDelta = speed * Time.deltaTime;

        Vector3 newPosition = Vector3.MoveTowards(transform.position, target.transform.position, speedDelta);

        transform.position = newPosition;

       


    }
   Vector3 tusMoveTowards(Vector3 predatorPosition, Vector3 target, float maxDistanceDelta)
    {
     // Draws vector that contaons distance from the predator to the target and also contains distance
     Vector3 rangeToClose = target - predatorPosition;
       // draws a line that represents the distance from the enemy to the player
        Debug.DrawRay(predatorPosition, rangeToClose, Color.green);
        // extracts distance of rangetoclose
        float distance =rangeToClose.magnitude;
        // could use distance for when player is in range

   //     Debug.Log("The distance" + distance);
    // extracts direction of rangetoclose
        Vector3 normRangeToClose = rangeToClose.normalized;
        // draws normal
        Debug.DrawRay(predatorPosition, normRangeToClose, Color.white);

         

         // new position is going to be current predator position + our speed delta along the direction
           Vector3 newPosition = predatorPosition - normRangeToClose * maxDistanceDelta;
            return newPosition;
           
  
    }

 
}
