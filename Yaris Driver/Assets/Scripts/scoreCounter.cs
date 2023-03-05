using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scoreCounter : MonoBehaviour
{
      // used to acces the text object
    public Text scoreText;
    // used to store the score total
    public float scoreTotal;
    // used to declare the amount of score that is increased per seconed
    public float scoreIncreasePerSecond;
    
    //used to access the objects used as spawners
    public GameObject spawner1;
    public GameObject spawner2;
    public GameObject spawner3;
    public GameObject spawner4;
    public GameObject spawner5;
    public GameObject spawner6;

    // Start is called before the first frame update
    void Start()
    {
         // sets the total score to 0
        scoreTotal = 0f;

        //disabling all spawners other than spawner1
          spawner2.SetActive(false);
          spawner3.SetActive(false);
          spawner4.SetActive(false);
          spawner5.SetActive(false);
          spawner6.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
         // converts the text to the current score
        scoreText.text = "Score: " + (int)scoreTotal;
        // used to increase the score by the set amount per second
        scoreTotal += scoreIncreasePerSecond * Time.deltaTime;
       

       //if statements used to change the difficulty of the game in regards to the score
        if (scoreTotal > 20.0f){
            spawner1.SetActive(false);
            spawner2.SetActive(true);
        }
         if (scoreTotal > 60.0f){
            spawner2.SetActive(false);
            spawner3.SetActive(true);
        }
          if (scoreTotal > 100.0f){
            spawner3.SetActive(false);
            spawner4.SetActive(true);
        }
         if (scoreTotal > 140.0f){
            spawner4.SetActive(false);
            spawner5.SetActive(true);     
         }
         if (scoreTotal > 180.0f){
            spawner5.SetActive(false);
            spawner6.SetActive(true);
         }
    }

}  
