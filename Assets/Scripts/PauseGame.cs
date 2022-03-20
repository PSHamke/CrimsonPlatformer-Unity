using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseGame : MonoBehaviour
{

    public bool isPaused = false;
    public AudioSource levelMusic;
    public GameObject pauseMenu;
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if(isPaused == false)
            {
                Time.timeScale = 0;
                isPaused = true;
                Cursor.visible = true;
                levelMusic.Pause();
                pauseMenu.active = true;
            }
            else
            {
                levelMusic.UnPause();
                Cursor.visible = false;
                isPaused = false;
                Time.timeScale = 1;
                pauseMenu.SetActive(false);
            }
        }
        
    }
    public void ResumeGame()
    {
        levelMusic.UnPause();
        Cursor.visible = false;
        isPaused = false;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    public void RestartLevel()
    {
        levelMusic.UnPause();
        Cursor.visible = false;
        isPaused = false;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(2);
    }

    public void BackMenu()
    {
        levelMusic.UnPause();
        Cursor.visible = false;
        isPaused = false;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(1);
    }

}
