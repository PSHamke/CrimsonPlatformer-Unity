using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level003 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fadeIn;
    void Start()
    {
        RedicetToLevel.redirectToLevel = 5;
        RedicetToLevel.nextLevel = 0;
        StartCoroutine(FadeInOff());
    }
    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }

 
}
