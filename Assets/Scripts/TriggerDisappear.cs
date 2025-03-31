using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDisappear : MonoBehaviour
{
    public GameObject objectToDisappear;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objectToDisappear.SetActive(false);
            Debug.Log("Door should dissappear/Trigger Entered");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            objectToDisappear.SetActive(true);
            Debug.Log("Door should reappear/Trigger Exit");
        }
    }
}