using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject ball;

    public Vector2 SpawnPosition;

    public void SpawnBall()
    {
        Instantiate(ball, SpawnPosition, new Quaternion(0, 0, 0, 0));
        ball.GetComponent<Rigidbody2D>().velocity = new Vector2(1f, 1f);
    }
    public void MoveBall()
    {
        ball.GetComponent<Rigidbody2D>().velocity = new Vector2(1f, 1f);
    }
}
