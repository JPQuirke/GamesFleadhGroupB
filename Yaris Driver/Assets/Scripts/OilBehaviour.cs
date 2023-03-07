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
        //calls the oilsplash script
         OilSplash oilSplash = gameObject.GetComponent<OilSplash>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        //if player collides with oil...
        if(collision.collider.tag == "Player")
        {
            //calls the isSplashed class from the OilSplash script
            oilSplash.isSplashed();
            //destroys oil object
            Destroy(gameObject);
        }
        //if oil hits magnet it gets destroyed
        if(collision.collider.tag == "ObstacleMagnet")
        {
            Destroy(gameObject);
        }
    }


}
