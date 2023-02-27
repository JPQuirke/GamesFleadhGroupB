using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilBehaviour : MonoBehaviour
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
            HealthManager healthManager = collision.gameObject.GetComponent<HealthManager>();
            
            //Debug.Log("The Player took damage");


            //healthManager.Heal(5);

            Destroy(gameObject);
        }
    }

    //add spinning feature
}
