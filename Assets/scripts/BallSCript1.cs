using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSCript1 : MonoBehaviour
{
    //[SerializeField]
    //public GameObject ball;//void virtaul

    [SerializeField]
    public GameObject Bila;
    public Transform Ball;

    public Transform StartPosition;

    private void Start()
    {
        Bila = GameObject.FindGameObjectWithTag("Bila");

        MoveBall();
    }

    public void MoveBall()
    {
        //ball.GetComponent<Rigidbody2D>().velocity = new Vector2(1f, 1f);
        Bila.GetComponent<Rigidbody2D>().AddForce(new Vector2(-8f, 1f), ForceMode2D.Impulse);
        Debug.LogError(Bila.GetComponent<Rigidbody2D>().velocity);
    }

    private void Update()
    {
        //if(Input.GetMouseButtonDown(0)) MoveBall();
        Bila = GameObject.FindGameObjectWithTag("Bila");
    }

    public void ResetBall()
    {
        Ball.position = StartPosition.position;
    }
}
