using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GemRed : MonoBehaviour
{
    public GameObject ScoreBox;
    public AudioSource collectSound;
    private void OnTriggerEnter()
    {
        GlobalScore.currentScore += 5000;
        collectSound.Play();
        Destroy(gameObject);
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
