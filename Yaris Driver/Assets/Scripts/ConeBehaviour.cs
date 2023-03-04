using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeBehaviour : MonoBehaviour
{
    //Reference for the Coneaudio in PlayerInventory
    public AudioClip audioFile;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        //If the cone collides with an object of the tag "Player"...
        if(collision.collider.tag == "Player")
        {
            //HealthManager script gets called...
            HealthManager healthManager = collision.gameObject.GetComponent<HealthManager>();
            
            //Shows in console that player took damage
            Debug.Log("The Player took damage");

            //gameObject (Cone) is destroyed on collision
            Destroy(gameObject);
        }

        //If theCone collides with the obstacleMagnet then it also gets destroyed
        if(collision.collider.tag == "ObstacleMagnet")
        {
            Destroy(gameObject);
        }
    }
}
