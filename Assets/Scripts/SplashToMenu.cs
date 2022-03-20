using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject theLogo;

    void Start()
    {
        StartCoroutine(RunSplash());
    }


    IEnumerator RunSplash()
    {
        yield return new WaitForSeconds(0.5f);
        theLogo.SetActive(true);
        yield return new WaitForSeconds(4.5f);
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
