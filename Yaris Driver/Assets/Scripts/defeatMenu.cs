using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class defeatMenu : MonoBehaviour
{
    public GameObject defeat;

    public bool isDefeated;
    // Start is called before the first frame update
    void Start()
    {
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
                EndGame();
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
        //loads the scene
        SceneManager.LoadScene("Yaris Driver");
    }
}

