using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static PereteInvisibil;

public class ScoreSystem : MonoBehaviour//scrore
{
    public PereteInvisibil perete;

    public TMP_Text score;

    public string Scor;

    //public int player1Dies;
    //public int player2Dies;

    public int player1Lives;
    public int player2Lives;

    public int StartScore;

    public Transform ball;
    public BallSCript1 ballScript;

    public GameObject menu;
    public TMP_Text winnerText;

    public bool gameIsPaused = false;

    public void PauseGame()
    {
        Time.timeScale = 0f;
        menu.SetActive(true);
        winnerText.text = "Paused";
        gameIsPaused = true;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f;
        menu.SetActive(false);
        gameIsPaused = false;
    }
    public void WriteScore()
    {
        //player1Dies = PereteInvisibil.player1DiesCount;
        //player2Dies = PereteInvisibil.player2DiesCount;

        player1Lives = PereteInvisibil.player1Lives;
        player2Lives = PereteInvisibil.player2Lives;

        Scor = player1Lives + " : " + player2Lives;
        score.text = Scor;
    }

    public void CheckScore()
    {
        if (player1Lives == 0) GameOver(2);
        if (player2Lives == 0) GameOver(1);
    }

    private void Update()
    {
        WriteScore();
        CheckScore();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                ResumeGame();
            } else
            {
                PauseGame();
            }
            //gameIsPaused? ResumeGame() : PauseGame();
        }
    }

    public void GameOver(int winner)
    {
        switch (winner)
        {
            case 1:
                menu.SetActive(true);
                winnerText.text = "Player 1 Wins";
                break;
            case 2:
                menu.SetActive(true);
                winnerText.text = "Player 2 Wins";
                break;
        }
    }

    public void Reset()
    {
        menu.SetActive(false);
        player1Lives = PereteInvisibil.player1Lives;//5
        player2Lives = PereteInvisibil.player2Lives;//5

        perete.Reset();
        ballScript.ResetBall();
    }
}
