using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIlkBehaviour : MonoBehaviour
{

     public AudioClip audioFile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            
            
            Debug.Log("The Player Is Drunk");


            

            Destroy(gameObject);
        }

        if(collision.collider.tag == "ObstacleMagnet")
        {
            Destroy(gameObject);
        }
    }
}
