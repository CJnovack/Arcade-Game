using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    public GameEnd gameEnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player 1") || other.CompareTag("Player 2"))
        {
            gameEnd.PlayerEntered(other.tag);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player 1") || other.CompareTag("Player 2"))
        {
            gameEnd.PlayerExited(other.tag);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
