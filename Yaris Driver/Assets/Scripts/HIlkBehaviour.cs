using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIlkBehaviour : MonoBehaviour
{
    //Reference for the Hilkaudio in PlayerInventory
    public AudioClip  audioFile;
    

    public void OnCollisionEnter2D(Collision2D collision)
    {
        //If the Hilk collides with an object of the tag "Player"...
        if(collision.collider.tag == "Player")
        {
            //Shows in console that hilk has initially been collected
            Debug.Log("The Player Is Drunk");
            
            //gameObject (TheHilk) is destroyed on collision
            Destroy(gameObject);
        }

        //If the hilk collides with the obstacleMagnet then it also gets destroyed
        if(collision.collider.tag == "ObstacleMagnet")
        {
            Destroy(gameObject);
        }
    }
}
