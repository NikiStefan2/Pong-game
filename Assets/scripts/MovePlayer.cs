using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class MovePlayer : NetworkBehaviour
{
    public Rigidbody2D rb;

    public float speed = 4f;

    public BallScript Ball;

    public void movement()
    {
        if (!isLocalPlayer) return;
        float yMov = Input.GetAxisRaw("Vertical");
        ///transform.Translate(0, Input.mousePosition.y * speed * Time.deltaTime, 0);
        transform.position 
    }

    private void Start()
    {
        rb.gravityScale = 0;

        //if (isServer) Ball.SpawnBall(new Vector2(transform.position.x + 1f, transform.position.y));
        Ball.SpawnBall();
    }

    private void Update()
    {
        movement();

        //if (Input.GetKeyDown(KeyCode.Space) && isLocalPlayer)
        //{
        //    Debug.LogWarning("merge spatiu");
        //    //Instantiate(ball, SpawnLocation, new Quaternion(0, 0, 0, 0));
        //    Ball.MoveBall();
        //    Ball.ball.GetComponent<Rigidbody2D>().velocity = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        //}

        //if (isServer) Ball.canShoot = true;
    }
}
