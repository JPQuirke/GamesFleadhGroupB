using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class HIlkBehaviour : MonoBehaviour
{
    //Reference for the Hilkaudio in PlayerInventory
    public AudioClip  audioFile;
    public GameObject mainCamera;
    float timeDelay = 6;
    
public void Start()
{
  
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

           PostProcessVolume ppv = mainCamera.GetComponent<PostProcessVolume>();

            ppv.enabled = true;

           
            StartCoroutine(DrunkEffect(timeDelay));

          
           
        }

        //If the hilk collides with the obstacleMagnet then it also gets destroyed
        if(collision.collider.tag == "ObstacleMagnet")
        {
            Destroy(gameObject);
        }
    }

   IEnumerator DrunkEffect(float waitTime)
    {
          PostProcessVolume ppv = mainCamera.GetComponent<PostProcessVolume>();
        
        yield return new WaitForSeconds(waitTime);
         ppv.enabled = false;
    } 
}
