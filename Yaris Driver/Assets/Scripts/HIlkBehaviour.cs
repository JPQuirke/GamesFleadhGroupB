using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class HIlkBehaviour : MonoBehaviour

{
    //Reference for the Hilkaudio in PlayerInventory
    public AudioClip  audioFile;
    public GameObject mainCamera;
    public float timeDelay = 5;
    public bool DrunkJoshie=false;
   public  PostProcessVolume ppv;
   float timeDecrease=1;

    public void Start()
    {
        PostProcessVolume ppv = mainCamera.GetComponent<PostProcessVolume>();
    }
    void Update()
    {
        if (DrunkJoshie==true)
        {
            timeDelay-=timeDecrease * Time.deltaTime;

        }
        if (timeDelay<0)
        {
            Drunk();
        }
    }
    

    public void OnCollisionEnter2D(Collision2D collision)
    {
        //If the Hilk collides with an object of the tag "Player"...
        if(collision.collider.tag == "Player")
        {
            //Shows in console that hilk has initially been collected
            Debug.Log("The Player Is Drunk");
            
            //gameObject (TheHilk) is destroyed on collision
            Destroy(gameObject);

            
            ppv.enabled = true;

            Drink();

            

            
        }

        //If the hilk collides with the obstacleMagnet then it also gets destroyed
        if(collision.collider.tag == "ObstacleMagnet")
        {
            Destroy(gameObject);
        }
    }
    
    void Drunk()
    {
        DrunkJoshie=false;
        ppv.enabled = false;
         
        
        
    }

    void Drink()
    {
        DrunkJoshie=true;
    }
}
