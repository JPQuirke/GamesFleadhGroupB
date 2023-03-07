using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class HIlkBehaviour : MonoBehaviour
{
    //Reference for the Hilkaudio in PlayerInventory
    public AudioClip  audioFile;
    public GameObject mainCamera;
    public float timeDelay=5f;
    public bool DrunkJoshie=false;
    public PostProcessVolume ppv;
    float timeDecrease=1f;

    

    public void Start(){
        
        PostProcessVolume ppv =mainCamera.GetComponent<PostProcessVolume>();
        
        ppv.enabled=false;
    }

    void Update()
    {
        //if josh is drunk start timer decrease
        if(DrunkJoshie==true)
        {
            timeDelay-=timeDecrease*Time.deltaTime;
        //if the time is less than 0... turn off effect
        // if(timeDelay<0)
        // {
        //     ppv.enabled=false;
        // }
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
            
            ppv.enabled=true;
            Drunk();
        }

        //If the hilk collides with the obstacleMagnet then it also gets destroyed
        if(collision.collider.tag == "ObstacleMagnet")
        {
            Destroy(gameObject);
        }
    }

        void Drunk()
        {
            //josh is drunk
            DrunkJoshie=true;
        }

        public void Sober()
        {

            //turn bool off
        DrunkJoshie=false;
        //turn effects off
        ppv.enabled=false;
        }

        
        }
    

