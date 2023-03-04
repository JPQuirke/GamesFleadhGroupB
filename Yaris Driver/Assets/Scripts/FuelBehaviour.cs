using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelBehaviour : MonoBehaviour
{
  //Reference for the FuelAudio in PlayerInventory
    public AudioClip audioFile;
    // Start is called before the first frame update
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //If the Fuel collides with an object of the tag "Player"...
        if(collision.collider.tag == "Player")
        {
            //Shows in console that Fuel has been restored
            Debug.Log("The Player got fuel");

           //gameObject (Fuel) is destroyed on collision
            Destroy(gameObject);
        }

        //If the Fuel collides with the obstacleMagnet then it also gets destroyed
        if(collision.collider.tag == "ObstacleMagnet")
        {
            Destroy(gameObject);
        }
    }
}
