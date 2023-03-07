using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        //pause is set to off
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void OnPause()
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
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }


//resumes game when button pressed
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

//brings player back to the main menu
    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

//game ends when quit game button is pressed
    public void QuitGame()
    {
        Application.Quit();
    }
}

