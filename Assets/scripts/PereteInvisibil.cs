using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PereteInvisibil : MonoBehaviour
{
    public static bool player1Dies = false;
    [SerializeField]
    //public static int player1DiesCount = 0;//statcic
    public static int player1Lives = 5;

    public static bool player2Dies = false;
    //public static int player2DiesCount = 0;//statcic
    [SerializeField]
    public static int player2Lives = 5;

    public void Player2Die()
    {
        player2Dies = true;
        //++player2DiesCount;
        --player2Lives;
    }

    public void Player1Die()
    {
        player1Dies = true;
        //++player1DiesCount;+--player1DiesCount;
        --player1Lives;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PereteInvisibilPlayer1")
        {
            Player1Die();
            //Debug.LogWarning(player1Dies + " " + player1DiesCount);
        }
        if(collision.gameObject.tag == "PereteInvisibilPlayer2")
        {
            Player2Die();
            //Debug.LogWarning(player2Dies + " " + player2DiesCount);
        }
    }
    public void Reset()
    {
        player1Lives = 5;
        player2Lives = 5;
    }
}
