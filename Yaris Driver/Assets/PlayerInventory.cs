using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    public int hilk =0;

    //Get a reference to the Text UI
    

    public int collectableValue;
    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
/*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag =="Collectables")
        {
            GameObject collectable = collision.gameObject;

            Debug.Log("Collided with a collectable: " +collision.collider.name);

            int collectableValue = collectable.GetComponent<HilkValue>().hilkValue;

            hilk += collectableValue;

           

            

            Destroy(collectable);

            Debug.Log("Player now has: " + hilk + "Hilk in their inventory. ");
        }
        
        Debug.Log("Player collided with: " + collision.collider.name);
    }*/
}
