using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    
    public AudioSource busAudio;
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
        if(collision.collider.tag =="Obstacle")
        {
            GameObject collectable = collision.gameObject;

            Destroy(collectable);

           //busAudio.clip=collectable.GetComponent<busBehaviour>().audioFile;
            //busAudio.Play();
           
           //hilkAudio.clip=collectable.GetComponent<HIlkBehaviour>().audioFile;
           //busAudio.Play();
            
        }
        
        Debug.Log("Player collided with: " + collision.collider.name);
    }
}
