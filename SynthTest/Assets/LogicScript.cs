using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    private int playerScore = 0;
    public Text scoreText;
    public BoxCollider2D deathzone;
    public GameObject gameOverScreen;
    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    public void Win()
    {
        gameOver();
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void gameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameExit()
    {
        Application.Quit();
    }
}
