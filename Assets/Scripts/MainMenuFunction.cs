using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuFunction : MonoBehaviour
{
    public AudioSource buttonPress;

    private void Start()
    {
      
        Cursor.visible = true; 
    }
    public void PlayGame()
    {
        PlayerPrefs.SetInt("CurrentTime", 100);
        PlayerPrefs.SetInt("CurrentLevelScore", 0);
        GlobalScore.currentScore = 0;
        buttonPress.Play();
        RedicetToLevel.redirectToLevel = 3;
        SceneManager.LoadScene(2);
    }
    public void QuitGame()
    {
        Application.Quit();

    }
}
