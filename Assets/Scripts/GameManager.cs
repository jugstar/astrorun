using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    int score, totalCoins;
    public static GameManager inst;

    [SerializeField] Text scoreText;

    [SerializeField] PlayerMovement playerMovement;
    [SerializeField] GameObject pauseUI, pauseCanvas;

    private void Start()
    {
        totalCoins = PlayerPrefs.GetInt("coin", 0);
        //Debug.Log(totalCoins);
    }
    public void IncrementScore ()
    {
        score++;
        totalCoins++;
        PlayerPrefs.SetInt("coin", totalCoins);

        scoreText.text = "SCORE: " + score;
        // Increase the player's speed
        playerMovement.speed += playerMovement.speedIncreasePerPoint;
    }

    private void Awake ()
    {
        inst = this;
    }

   public void pause()
    {
        Time.timeScale = 0;
        pauseUI.SetActive(false);
        pauseCanvas.SetActive(true);

    }
   public void resume()
    {
        Time.timeScale = 1;
        pauseUI.SetActive(true);
        pauseCanvas.SetActive(false);
    }

    public void home()
    {
        Time.timeScale = 1;
        pauseUI.SetActive(true);
        pauseCanvas.SetActive(false);
        SceneManager.LoadScene(0);
    }

    public void exit()
    {
        Application.Quit();
    }
}