using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject ball;

    public Transform player;

    public Vector2 SpawnLocation;

    public bool canShoot = false;

    private void Update()
    {
        SpawnLocation = new Vector2(player.position.x + 5f, player.position.y);

        if (Input.GetMouseButtonDown(0))
        {
            Debug.LogWarning("merge spatiu");
            //Instantiate(ball, SpawnLocation, new Quaternion(0, 0, 0, 0));
            MoveBall();
        }
    }


    //public void SpawnBall() non albastru
    //{
    //    Instantiate(ball, SpawnLocation, new Quaternion(0, 0, 0, 0));
    //}

    //private void OnServerInitialized()//albastru
    //{
    //    SpawnBall();
    //}

    //private void Start()//albastru too siasta si asta  dupa github     github lol    hehe  gata pa
    //{
    //    Instantiate(ball, SpawnLocation, new Quaternion(0, 0, 0, 0));
    //}

    public void MoveBall()
    {
        Debug.Log("Shoot? poate vrei sa tintesti mai intai");//intanati
        ball.GetComponent<Rigidbody2D>().gravityScale = 1;
        if (Input.GetMouseButtonDown(0) && canShoot)
        {
            ball.GetComponent<Rigidbody2D>().velocity = new Vector2(Input.mousePosition.x * 0.05f, Input.mousePosition.y * 0.05f);
        }
    }

    public void SpawnBall(Vector2 where)
    {
        Instantiate(ball, where, new Quaternion(0, 0, 0, 0));
        ball.GetComponent<Rigidbody2D>().gravityScale = 0;
    }
}
