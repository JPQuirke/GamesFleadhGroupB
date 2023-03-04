using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthManager : MonoBehaviour
{
        int health = 3;
    public TextMeshProUGUI Health1;
    public TextMeshProUGUI Health2;
    public TextMeshProUGUI Health3;

    public defeatMenu defeatMenu;

   public int repair = 1;


    

 //   DefeatMenu defeatMenu;
    // Start is called before the first frame update
    void Start()
    {
        defeatMenu defeatMenu = gameObject.GetComponent<defeatMenu>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health  <1)
        {
             
            defeatMenu.OnDefeat();
        } 

      
       
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag =="Collectables" || collision.collider.tag =="Crash" || collision.collider.tag == "Cone")
        {
                 health -= 1;
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
            health +=1;
            if (health == 2){
                  Health2.enabled = true;
                }
                if (health == 3){
                 Health1.enabled = true;
                }
                
                   
        }
        

        

    }


}

