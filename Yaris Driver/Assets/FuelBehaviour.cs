using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelBehaviour : MonoBehaviour
{
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
            
            
            Debug.Log("The Player got fuel");


           
            Destroy(gameObject);
        }

        if(collision.collider.tag == "ObstacleMagnet")
        {
            Destroy(gameObject);
        }
    }
}
