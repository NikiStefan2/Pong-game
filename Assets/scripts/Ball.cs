using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject ball;

    public Transform player;

    public Vector2 SpawnLocation;

    private void Update()
    {
        SpawnLocation = new Vector2(player.position.x + 5f, player.position.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            MoveBall();
        }
    }

    public void SpawnBall()
    {
        Instantiate(ball, SpawnLocation, new Quaternion(0, 0, 0, 0));
    }

    private void Start()
    {
        SpawnBall();
    }

    public void MoveBall()
    {
        ball.GetComponent<Rigidbody2D>().velocity = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    }
}
