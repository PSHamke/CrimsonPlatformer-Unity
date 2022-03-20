using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGripper : MonoBehaviour
{
    public GameObject theLedge;
    public GameObject thePlayer;

    private void OnTriggerEnter()
    {
        thePlayer.transform.parent= theLedge.transform;
    }

    private void OnTriggerExit()
    {
        thePlayer.transform.parent = null;
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
