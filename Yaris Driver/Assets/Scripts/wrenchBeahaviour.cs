using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrenchBeahaviour : MonoBehaviour
{
     // accesing the audio stored in sprites sfx
     public AudioClip audioFile;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        //If the Wrench collides with an object of the tag "Player"...
        if(collision.collider.tag == "Player")
        {
            //HealthManager script gets called...
            HealthManager healthManager = collision.gameObject.GetComponent<HealthManager>();
            
            
            //Shows in console that player was healed
            Debug.Log("The player was healed");

            //audioFile.play
            //healthManager.Heal(5);

            //gameObject (Wrench) is destroyed on collision
            Destroy(gameObject);
        }
        //If the Wrench collides with the obstacleMagnet then it also gets destroyed
        if(collision.collider.tag == "ObstacleMagnet")
        {
            Destroy(gameObject);
        }
    }
}
