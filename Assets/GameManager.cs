using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public GameObject gameOverCanvas;
    public GameObject scoreCanvas;
    public GameObject silverCoin;
    public GameObject goldCoin;
    // Start is called before the first frame update
    private void Start()
    {
        silverCoin.SetActive(false);
        goldCoin.SetActive(false);
        gameOverCanvas.SetActive(false);
        scoreCanvas.SetActive(true);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    public void GameOver()
    {
        if (Score.score >= 20 && Score.score <= 49)
            silverCoin.SetActive(true);
        else if (Score.score >= 50)
            goldCoin.SetActive(true);

        gameOverCanvas.SetActive(true);
        scoreCanvas.SetActive(false);
        Time.timeScale = 0;
        FlyLittleBird.playSound("hit");
    }
    public void Replay()
    {
        SceneManager.LoadScene(1);
    }
}
