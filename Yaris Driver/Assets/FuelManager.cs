using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FuelManager : MonoBehaviour
{
    public Text fuelText;

    public float fuelDecreasePerSecond;

    float fuelAmount;

    // Start is called before the first frame update
    void Start()
    {
        fuelAmount = 100f;
    }

    // Update is called once per frame
    void Update()
    {

         fuelText.text = "Fuel: " + (int)fuelAmount+"%";
        fuelAmount -= fuelDecreasePerSecond *Time.deltaTime;

       
        
    }
}
