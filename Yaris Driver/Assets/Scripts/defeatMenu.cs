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
          if (isDefeated == false) {
                EndGame();
            }
          
    }

    public void EndGame()

    {
          defeat.SetActive(true);
        Time.timeScale = 0f;
        isDefeated = true;
    }

      public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

