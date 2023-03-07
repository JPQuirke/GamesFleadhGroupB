using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    //this is for the pauseMenu
    public GameObject pauseMenu;
    public bool isPaused;
    //creates a reference to the sound objects
   public AudioSource radioSound; 
   public AudioSource collectablesSound;
   public AudioSource obstaclesSound;
   public AudioSource engineSound;  
    
    // Start is called before the first frame update
    void Start()
    {
        //pause is set to off
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    public void OnPause()
    {
        
        
            //if game is not paused, pause it 
            if (isPaused == false) {
                
              
                
                //pauses game
                PauseGame();
            }
            //if game is paused then unpause it
            else{
                
                 
                
                //resumes game
                ResumeGame();
            }

    }

//pauses game when the ESCAPE button is pressed
    public void PauseGame(){
        //disables sounds
         
         obstaclesSound.enabled=false;
         engineSound.enabled=false;
         collectablesSound.enabled=false;
         radioSound.enabled=false;
//turns on pause menu
        pauseMenu.SetActive(true);
        //freezes time
        Time.timeScale = 0f;
        //sets bool to true
        isPaused = true;
    }


//resumes game when button pressed
    public void ResumeGame()
    {
        //enables sounds
    obstaclesSound.enabled=true;
    engineSound.enabled=true;
    collectablesSound.enabled=true;
    radioSound.enabled=true;

        //turns off pause menu
        pauseMenu.SetActive(false);
        //unfreezes time
        Time.timeScale = 1f;
       //sets bool to false
        isPaused = false;
    }

//brings player back to the main menu

    public void GoToMainMenu()
    {
        //unfreezes time
        Time.timeScale = 1f;
        //loads the main menu scene
        SceneManager.LoadScene("Main Menu");
    }

//game ends when quit game button is pressed
    public void QuitGame()
    {
        Application.Quit();
    }
}

