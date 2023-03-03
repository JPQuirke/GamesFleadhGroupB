using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilSplash : MonoBehaviour
 
 
{
    public GameObject splash;
    public bool splashed;
     public float time;
    


    
    // Start is called before the first frame update
    void Start()
    {
        splash.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
    }
    IEnumerator Splash(float waitTime)
    {
        splashed=true;
        yield return new WaitForSeconds(waitTime);
        splashed=false;
    }

    public void isSplashed()
    {
        if(splashed == false)
        {
             StartCoroutine(Splash(time));
             EndSplash();
            
        }
    }

     public void EndSplash()
     {
        splash.SetActive(true);
        splashed = true;
     }




}
