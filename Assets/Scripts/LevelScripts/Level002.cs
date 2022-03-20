using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level002 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject fadeIn;
    void Start()
    {
        RedicetToLevel.redirectToLevel = 4;
        RedicetToLevel.nextLevel = 5;
        StartCoroutine(FadeInOff());
    }
    IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }

 
}
