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
        if(collision.collider.tag =="Obstacle" || collision.collider.tag == "Item" ||  collision.collider.tag == "Wrench" || collision.collider.tag == "Fuel" );
        {
            GameObject collectable = collision.gameObject;

            Destroy(collectable);

           busAudio.clip=collectable.GetComponent<busBehaviour>().audioFile;
            busAudio.Play();
           
           hilkAudio.clip=collectable.GetComponent<HIlkBehaviour>().audioFile;
           hilkAudio.Play(); 
            
            coneAudio.clip=collectable.GetComponent<ConeBehaviour>().audioFile;
            coneAudio.Play();
           
            oilleakAudio.clip=collectable.GetComponent<OilBehaviour>().audioFile;
            oilleakAudio.Play();
           
           fuelAudio.clip=collectable.GetComponent<FuelBehaviour>().audioFile;
           fuelAudio.Play();

           wrenchAudio.clip=collectable.GetComponent<wrenchBeahaviour>().audioFile;
           wrenchAudio.Play();


        }
        
        Debug.Log("Player collided with: " + collision.collider.name);
    }
}
