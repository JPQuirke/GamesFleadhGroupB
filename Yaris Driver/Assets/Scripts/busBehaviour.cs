using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class busBehaviour : MonoBehaviour
{
    //Reference for the BusAudio in PlayerInventory
    public AudioClip audioFile;
    

    public void OnCollisionEnter2D(Collision2D collision)
    {
        //If the Bus collides with an object of the tag "Player"...
        if(collision.collider.tag == "Player")
        {
            //HealthManager script gets called...
            HealthManager healthManager = collision.gameObject.GetComponent<HealthManager>();
            
            //Shows in console that player took damage when collided with bus
            Debug.Log("The Player took damage");

            //gameObject (Bus) is destroyed on collision
            Destroy(gameObject);
        }
        //If the Bus collides with the obstacleMagnet then it also gets destroyed   
        if(collision.collider.tag == "ObstacleMagnet")
        {
            Destroy(gameObject);
        }
    }
}
