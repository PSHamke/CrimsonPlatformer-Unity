using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GlobalTimer : MonoBehaviour
{

    public GameObject timeDisplay01;
    public GameObject timeDisplay02;
    public FinishLevel finish;
    public bool isTakingTime = false;
    public int theSeconds;
    public static int extendScore;
    // Start is called before the first frame update
    void Start()
    {
        theSeconds = PlayerPrefs.GetInt("CurrentTime");
    }

    // Update is called once per frame
    void Update()
    {
        extendScore = theSeconds;
        if (isTakingTime == false)
        {
            StartCoroutine(SubstractSecond());
        }
    }

    IEnumerator SubstractSecond()
    {
        isTakingTime = true;
        theSeconds -= 1;
        timeDisplay01.GetComponent<Text>().text = "" + theSeconds;
        timeDisplay02.GetComponent<Text>().text = "" + theSeconds;
        yield return new WaitForSeconds(1);
        if (theSeconds == 0)
        {
            TimeIsUp();
        }
        isTakingTime = false;
    }

    private void TimeIsUp()
    {

        // get the script on the object (make sure the script is a public class)      
        
        finish.FinishInit(1);
    }



}
