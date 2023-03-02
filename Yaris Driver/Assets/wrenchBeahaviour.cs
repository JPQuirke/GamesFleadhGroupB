using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wrenchBeahaviour : MonoBehaviour
{
     // accesing the audio stored in sprites sfx
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
            HealthManager healthManager = collision.gameObject.GetComponent<HealthManager>();
            
            Debug.Log("The player was healed");

            audioFile.play
            //healthManager.Heal(5);

            Destroy(gameObject);
        }

        if(collision.collider.tag == "ObstacleMagnet")
        {
            Destroy(gameObject);
        }
    }
}
