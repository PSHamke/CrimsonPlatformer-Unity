using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{
    public GameObject youFell;
    public GameObject LevelAudio;
    public GameObject FadeOut;
    private void OnTriggerEnter()
    {
        StartCoroutine(YouFellOff());
        
    }
    IEnumerator YouFellOff()
    {
        youFell.SetActive(true);
        LevelAudio.SetActive(false);
        yield return new WaitForSeconds(3);
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        GlobalScore.currentScore = PlayerPrefs.GetInt("CurrentLevelScore");
        PlayerPrefs.SetInt("CurrentTime", GlobalTimer.extendScore);
        if (GlobalTimer.extendScore>0)
            SceneManager.LoadScene(RedicetToLevel.redirectToLevel);
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
