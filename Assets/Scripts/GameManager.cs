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
    //public TextMeshProUGUI gameEndText;
    public Button restartButton;
    // Start is called before the first frame update
    void Start()
    {
        //gameEndText.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
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

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameEnd()
    {
        restartButton.gameObject.SetActive(true);
    }
}
