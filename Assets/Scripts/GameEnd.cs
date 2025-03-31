using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    private bool trigger1Entered = false;
    private bool trigger2Entered = false;
    public GameObject gameEndScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && gameObject.tag == "Trigger1")
        {
            trigger1Entered = true;
        }
        else if (other.gameObject.tag == "Player" && gameObject.tag == "Trigger2")
        {
            trigger2Entered = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger1Entered && trigger2Entered)
        {
            gameEndScreen.SetActive(true);
        }
    }
}
