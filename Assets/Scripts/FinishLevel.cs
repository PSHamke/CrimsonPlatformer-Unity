using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FinishLevel : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;
    public int timeCalc;
    public int scoreCalc;
    public int totalScored;
    public GameObject levelBlocker;
    public GameObject FadeOut;
    public GameObject endText;
    private void OnTriggerEnter()
    {
        FinishInit(0);
    }

    public void FinishInit(int callReason)
    {
        Debug.Log("Here");

        GetComponent<BoxCollider>().enabled = false;
        levelBlocker.SetActive(true);
        levelBlocker.transform.parent = null;
        if(callReason == 1)
        {
            endText.GetComponent<Text>().text = "GAME OVER";
        }
        timeCalc = GlobalTimer.extendScore * 100;
        timeLeft.GetComponent<Text>().text = "Time Left: " + GlobalTimer.extendScore + " x 100";
        theScore.GetComponent<Text>().text = "Score: " + GlobalScore.currentScore;
        totalScored = GlobalScore.currentScore + timeCalc;
        totalScore.GetComponent<Text>().text = "Total Score: " + totalScored;
        PlayerPrefs.SetInt("CurrentTime",GlobalTimer.extendScore);
        PlayerPrefs.SetInt("CurrentLevelScore", totalScored);
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        StartCoroutine(CalculateScore(callReason));
    }

    IEnumerator CalculateScore(int callReason)
    {
        endText.SetActive(true);
        yield return new WaitForSeconds(1f);
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(1f);
        theScore.SetActive(true);
        yield return new WaitForSeconds(1f);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(2f);
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(2f);
        GlobalScore.currentScore = totalScored;
        if(callReason == 1)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(RedicetToLevel.nextLevel);
        }
      
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
