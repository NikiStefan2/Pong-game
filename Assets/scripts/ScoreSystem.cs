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

    public void WriteScore()
    {
        //player1Dies = PereteInvisibil.player1DiesCount;
        //player2Dies = PereteInvisibil.player2DiesCount;

        player1Lives = PereteInvisibil.player1Lives;
        player2Lives = PereteInvisibil.player2Lives;

        Scor = player1Lives + " : " + player2Lives;
        score.text = Scor;
    }

    private void Update()
    {
        WriteScore();
    }
}
