using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    private bool player1InTrigger = false;
    private bool player2InTrigger = false;
    public GameObject gameEndScreen;
    public Button restartButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PlayerEntered(string playerTag)
    {
        if (playerTag == "Player 1")
            player1InTrigger = true;
        if (playerTag == "Player 2")
            player2InTrigger = true;

        CheckGameEnd();
    }

    public void PlayerExited(string playerTag)
    {
        if (playerTag == "Player1")
            player1InTrigger = false;
        else if (playerTag == "Player2")
            player2InTrigger = false;
    }

    private void CheckGameEnd()
    {
        if (player1InTrigger && player2InTrigger)
        {
            gameEndScreen.SetActive(true);
            restartButton.gameObject.SetActive(true);
            Debug.Log("RestartButtonShouldAppear");
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    
    }
    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "Player" && gameObject.tag == "Trigger1")
        //{
          //  trigger1Entered = true;
        //}
        //else if (other.gameObject.tag == "Player" && gameObject.tag == "Trigger2")
        //{
          //  trigger2Entered = true;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        //if (trigger1Entered && trigger2Entered)
        //{
          //  gameEndScreen.SetActive(true);
        //}
    }
}
