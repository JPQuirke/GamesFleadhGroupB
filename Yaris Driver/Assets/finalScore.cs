using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalScore : MonoBehaviour
{

    public Text scoreText;
    scoreCounter scoreCounter;

    public float scoreTotal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       scoreText.text= "Your final score: " + scoreCounter.scoreText.text;
    }
}
