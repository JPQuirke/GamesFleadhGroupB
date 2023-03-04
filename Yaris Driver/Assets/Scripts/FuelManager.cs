using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FuelManager : MonoBehaviour
{
    // links the fuel display text to the script
    public Text fuelText;
    // the value that the fuel decreases by per second
    public float fuelDecreasePerSecond;
    // The Total fuel held
    float fuelAmount;
    // links the no fuel endGame panel to the script
    public GameObject noFuel;
    // bool to determine if car has fuel
    public bool hasFuel;

    // Start is called before the first frame update
    void Start()
    {
        // fuel starts as 100
        fuelAmount = 100f;
        // no fuel panel disabled
        noFuel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        // if fuel is less then 0
        if (fuelAmount < 0)
        {
            // triggers no fuel 
            NoFuel();
        }
        // updates the fuel display text by the current fuel
         fuelText.text = "Fuel: " + (int)fuelAmount+"%";
        // decreses the current fuel by the fuel decrease value per second
        fuelAmount -= fuelDecreasePerSecond *Time.deltaTime;

       
        
    }

    void NoFuel()
    {
        // triggers end game if bool is false
        if(hasFuel == false)
        {
            EndGame();
        }
    }
    public void EndGame()

    {
        // sets the no fuel panel to active 
          noFuel.SetActive(true);
        // freezes the scene 
        Time.timeScale = 0f;
        // sets the bool to true
        hasFuel = true;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // if car collides with fuel
        if (collision.collider.tag == "Fuel")
        {
            // increases fuel by 15
            fuelAmount+=15f;
            // checks to see if fuel is greater then 100 and then sets it to 100 after
            if (fuelAmount > 100)
            {
                fuelAmount = 100;
            }
        }
    }

}
