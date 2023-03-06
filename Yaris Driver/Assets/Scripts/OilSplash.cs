using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilSplash : MonoBehaviour

 
 
{
    // splash screen
    public GameObject splash;
    // splash bool
    public bool splashed = false;

    // time
    public float time;
    // time decrease
    public float timeDecrease;
    
   
    


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // if splasehed starts a timer
       if(splashed == true)
       {
          time -= timeDecrease *Time.deltaTime;
       }
        

        // when timer is less then 0 it calls the endsplash method
             if(time < 0)
          {
            EndSplash();

          }
    }
    public void isSplashed()
    {
        // resets time
        time = 6;
        // activates the splash screen
             splash.SetActive(true);
        // sets the splash bool to true
        splashed =true;
             
    }


 

     public void EndSplash()
     {
        // turns off the oil splash screen
        splash.SetActive(false);
        // puts the splash bool to false
        splashed =false;
        
     }




}
