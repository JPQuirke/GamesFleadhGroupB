using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilBehaviour : MonoBehaviour
{
    public AudioClip audioFile;
     public OilSplash oilSplash;
    // Start is called before the first frame update
    void Start()
    {
         OilSplash oilSplash = gameObject.GetComponent<OilSplash>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
              oilSplash.isSplashed();

            Destroy(gameObject);
        }

        if(collision.collider.tag == "ObstacleMagnet")
        {
            Destroy(gameObject);
        }
    }


}
