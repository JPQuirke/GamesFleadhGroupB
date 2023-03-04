using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthManager : MonoBehaviour
{
    // value for health
     int health = 3;
    // images used for the health display
    public TextMeshProUGUI Health1;
    public TextMeshProUGUI Health2;
    public TextMeshProUGUI Health3;
    // references the defeat menu panel
    public defeatMenu defeatMenu;
    // the value the wrench can repair
   public int repair = 1;


    

 //   DefeatMenu defeatMenu;
    // Start is called before the first frame update
    void Start()
    {
        // links the defeat screen script to the health script
        defeatMenu defeatMenu = gameObject.GetComponent<defeatMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        // if health is less then 1 then it will trigger defeat menu
        if (health  <1)
        {
             // calls on defeat method from the defeat script
            defeatMenu.OnDefeat();
        } 

      
       
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag =="Collectables" || collision.collider.tag =="Crash" || collision.collider.tag == "Cone")
        {
                 health -= 1;
            // disables car sprites to visualise how many lives are left
                if (health == 2){
                  Health1.enabled = false;
                }
                if (health == 1){
                 Health2.enabled = false;
                }
                if (health == 0){
                    Health3.enabled = false;
                   Debug.Log("You have Died");
                   
                }

                

        }
        else if(collision.collider.tag=="Wrench")
        {
            // enables car car sprites to visualise how many lives are left when car repairs
            health += 1;
            if (health == 2){
                  Health2.enabled = true;
                }
                if (health == 3){
                 Health1.enabled = true;
                }
        // prevents car lives exceeding 3
            if (health == 4)
            {
                health -=1;
            }
                
                   
        }
        

        

    }


}

