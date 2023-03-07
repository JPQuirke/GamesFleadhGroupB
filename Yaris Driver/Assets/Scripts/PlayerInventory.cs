using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    // Audio source for the sprites - 
    public AudioSource busAudio;
   public AudioSource wrenchAudio;
   public AudioSource coneAudio;
   public AudioSource fuelAudio;
   public AudioSource oilleakAudio;
   public AudioSource hilkAudio;
    //Get a reference to the Text UI
    

    
    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if player collides with vehicle
        if(collision.collider.tag =="Crash")
        {
            //refers to object as a collectable
            GameObject collectable = collision.gameObject;
            //destroy game object
            Destroy(collectable);
            //vehicle sound on collision
           busAudio.clip=collectable.GetComponent<busBehaviour>().audioFile;
           busAudio.Play();
           
            
        }
        //if player collides with cone
        if(collision.collider.tag =="Cone")
        {
            //refers to object as a collectable
            GameObject collectable = collision.gameObject;
            //destroy game object
            Destroy(collectable);
           //cone sound on collision    
            coneAudio.clip=collectable.GetComponent<ConeBehaviour>().audioFile;
            coneAudio.Play();
           
        
        }
        //if player collides with oil
        if(collision.collider.tag =="Oil")
        {
            //refers to object as a collectable
            GameObject collectable = collision.gameObject;
            //destroy game object
            Destroy(collectable);
        //oil sound on collision
        oilleakAudio.clip=collectable.GetComponent<OilBehaviour>().audioFile;
            oilleakAudio.Play();
        }
        //if player collides with hilk
        if( collision.collider.tag == "Item" )
        {
            //refers to object as a collectable
            GameObject collectable = collision.gameObject;
             //destroy game object
            Destroy(collectable);

        //oil sound is played on collision
           hilkAudio.clip=collectable.GetComponent<HIlkBehaviour>().audioFile;
           hilkAudio.Play(); 
        }

        //if player collides with wrench
        if( collision.collider.tag == "Wrench"  )
        {
            //refers to object as a collectable
            GameObject collectable = collision.gameObject;
            //destroy game object
            Destroy(collectable);
            //wrench sound is played on collision
           wrenchAudio.clip=collectable.GetComponent<wrenchBeahaviour>().audioFile;
           wrenchAudio.Play();


        }
        //if player collides with fuel
        if(   collision.collider.tag == "Fuel"  )
        {
            //refers to object as a collectable
            GameObject collectable = collision.gameObject;
            //destroy game object
            Destroy(collectable);
          //fuel sound is played on collision
           fuelAudio.clip=collectable.GetComponent<FuelBehaviour>().audioFile;
           fuelAudio.Play();
        }
        
        //Console prints that player collided with object
        Debug.Log("Player collided with: " + collision.collider.name);
    }
}
