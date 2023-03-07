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
        
        if(collision.collider.tag =="Crash")
        {
            GameObject collectable = collision.gameObject;
            
            Destroy(collectable);
            
           busAudio.clip=collectable.GetComponent<busBehaviour>().audioFile;
           busAudio.Play();
           
            
        }

        if(collision.collider.tag =="Cone")
        {
            GameObject collectable = collision.gameObject;

            Destroy(collectable);

            coneAudio.clip=collectable.GetComponent<ConeBehaviour>().audioFile;
            coneAudio.Play();
           
        
        }

        if(collision.collider.tag =="Oil")
        {
            GameObject collectable = collision.gameObject;

            Destroy(collectable);
        
        oilleakAudio.clip=collectable.GetComponent<OilBehaviour>().audioFile;
            oilleakAudio.Play();
        }

        if( collision.collider.tag == "Item" )
        {
            GameObject collectable = collision.gameObject;

            Destroy(collectable);

           hilkAudio.clip=collectable.GetComponent<HIlkBehaviour>().audioFile;
           hilkAudio.Play(); 
        }

        
        if(   collision.collider.tag == "Wrench"  )
        {
            GameObject collectable = collision.gameObject;

            Destroy(collectable);

           wrenchAudio.clip=collectable.GetComponent<wrenchBeahaviour>().audioFile;
           wrenchAudio.Play();


        }

        if(   collision.collider.tag == "Fuel"  )
        {
            GameObject collectable = collision.gameObject;

            Destroy(collectable);

           fuelAudio.clip=collectable.GetComponent<FuelBehaviour>().audioFile;
           fuelAudio.Play();

           

        }

        
        
        Debug.Log("Player collided with: " + collision.collider.name);
    }
}
