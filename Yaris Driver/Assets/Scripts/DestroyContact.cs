using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyContact : MonoBehaviour
{
    
    
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

        
            
        }
        
        
    }
}
