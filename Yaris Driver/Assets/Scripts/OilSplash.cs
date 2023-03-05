using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilSplash : MonoBehaviour
 
 
{
    public GameObject splash;
    public bool splashed = false;
     public float time;
    


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
       
          
    }
    public void isSplashed()
    {
             splash.SetActive(true);
             StartCoroutine(Splash(time));
             EndSplash();
    }
    IEnumerator Splash(float waitTime)
    {
        splashed=true;
        yield return new WaitForSeconds(waitTime);
        splashed=false;
    }

 

     public void EndSplash()
     {
        splash.SetActive(false);
        splashed = true;
     }




}
