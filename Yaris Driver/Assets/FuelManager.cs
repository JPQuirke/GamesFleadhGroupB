using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FuelManager : MonoBehaviour
{
    public Text fuelText;

    public float fuelDecreasePerSecond;

    float fuelAmount;

    public GameObject noFuel;

    public bool hasFuel;

    // Start is called before the first frame update
    void Start()
    {
        fuelAmount = 100f;

        noFuel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

        if (fuelAmount < 0)
        {
            NoFuel();
        }
         fuelText.text = "Fuel: " + (int)fuelAmount+"%";
        fuelAmount -= fuelDecreasePerSecond *Time.deltaTime;

       
        
    }

    void NoFuel()
    {
        if(hasFuel == false)
        {
            EndGame();
        }
    }
    public void EndGame()

    {
          noFuel.SetActive(true);
        Time.timeScale = 0f;
        hasFuel = true;
    }

   // void OnCollisionEnter2D

}
