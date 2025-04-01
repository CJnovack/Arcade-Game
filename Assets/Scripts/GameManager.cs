using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject titleScreen;
    public Button startButton;
    public TextMeshProUGUI gameEndText;
    public Button restartButton;
    private bool trigger1Entered = false;
    private bool trigger2Entered = false;
    public GameObject GameEndScreen;
    public bool isGameActive;
    //public bool gameEnd = false;
    private PlayerControl1 playerControl1Script;
    private PlayerControl1 playerControl2Script;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
       // isGameActive = true;
        playerControl1Script = GameObject.Find("Player1").GetComponent<PlayerControl1>();
        playerControl2Script = GameObject.Find("Player2").GetComponent<PlayerControl1>();
        //gameEndText.gameObject.SetActive(true);
        
    
}

    // Update is called once per frame

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
    void Update()
    {
        if (trigger1Entered && trigger2Entered)
        {
            GameEndScreen.SetActive(true);
            restartButton.gameObject.SetActive(true);
            Debug.Log("RestartButtonShouldAppear");
            isGameActive = false;
            playerControl1Script.isGameActive = false;
            playerControl2Script.isGameActive = false;

        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            // or if (Input.GetButtonUp("Cancel")) {
            Application.Quit();
        }
        

    }
    public void StartGame()
    {
        titleScreen.gameObject.SetActive(false);
        Time.timeScale = 1f;
        startButton.gameObject.SetActive(false);
    }

    private void Awake()
    {
        Time.timeScale = 0f;
    }

    private void OnEnable()
    {
        startButton.onClick.AddListener(StartGame);
    }

    private void OnDisable()
    {
        startButton.onClick.RemoveListener(StartGame);
    }

    public void GameEnd()
    {
        restartButton.gameObject.SetActive(true);
        isGameActive = false;
    }

   public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
