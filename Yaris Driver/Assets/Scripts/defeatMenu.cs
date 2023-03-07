using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class defeatMenu : MonoBehaviour
{
    //references the defeat object
    public GameObject defeat;
    //calls audio references
    public AudioSource radioSource;
    public AudioSource collectablesSource;
    public AudioSource obstaclesSource;
    public AudioSource engineSource;
    

    public bool isDefeated;

    public GameObject oilSplash;
    // Start is called before the first frame update
    void Start()
    {
        //enables sounds
      radioSource.enabled=true;
      collectablesSource.enabled=true;
      obstaclesSource.enabled=true;
      engineSource.enabled=true;
      
        defeat.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnDefeat()
    {
        //if player is dead send to EndGame() class
          if (isDefeated == false) {
            //ends game
                EndGame();
                //turns off oil canvas
                oilSplash.SetActive(false);
                
                //disables sounds
                radioSource.enabled=false;
                collectablesSource.enabled=false;
               obstaclesSource.enabled=false;
               engineSource.enabled=false;
      
                
            }
          
    }

    public void EndGame()

    {
        //Activated death screen
          defeat.SetActive(true);
        //freezes game
        Time.timeScale = 0f;
        //changes bool to true
        isDefeated = true;
    }



      public void GoToMainMenu()
    {
        //unfreezez the game
        Time.timeScale = 1f;
        //loads main menu
        SceneManager.LoadScene("Main Menu");
    }
//quits game when button is pressed
    public void QuitGame()
    {
        Application.Quit();
    }


//plays game when button is pressed    
    public void PlayAgain()
    {
        //unfreezez the game
        Time.timeScale = 1f;
        //loads the scene
        SceneManager.LoadScene("Yaris Driver");
    }
}

