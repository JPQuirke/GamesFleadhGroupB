using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    // Audio source for the sprites - 
    public AudioSource busAudio;
    public AudioSource hilkAudio;
   public AudioSource wrenchAudio;
   public AudioSource coneAudio;
   public AudioSource fuelAudio;
   public AudioSource oilleakAudio;
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
        if(collision.collider.tag =="Obstacle")
        {
            GameObject collectable = collision.gameObject;

            Destroy(collectable);

           busAudio.clip=collectable.GetComponent<busBehaviour>().audioFile;
            busAudio.Play();
           
           hilkAudio.clip=collectable.GetComponent<HIlkBehaviour>().audioFile;
           hilkAudio.Play();
            
          /*coneAudio.clip=collectable.GetComponent<ConeBehaviour>().audioFile;
            coneAudio.Play();
           
           wrenchAudio.clip=collectable.GetComponent<wrenchBehaviour>().audioFile;
           wrenchAudio.Play();*/
        }
        
        Debug.Log("Player collided with: " + collision.collider.name);
    }
}
