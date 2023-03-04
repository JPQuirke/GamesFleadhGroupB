using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emptyobjectbehaviout : MonoBehaviour
{
    // Start is called before the first frame update
        public void OnCollisionEnter2D(Collision2D collision)
    {
     
        //If the Bus collides with the obstacleMagnet then it also gets destroyed   
        if(collision.collider.tag == "ObstacleMagnet")
        {
            Destroy(gameObject);
        }
    }
}
