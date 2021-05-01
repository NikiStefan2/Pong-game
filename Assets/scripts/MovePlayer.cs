using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class MovePlayer : NetworkBehaviour
{
    public Rigidbody2D rb;

    public float speed = 4f;

    public void movement()
    {
        if (!isLocalPlayer) return;
        float yMov = Input.GetAxisRaw("Vertical");
        transform.Translate(0, yMov * speed * Time.deltaTime, 0);
    }

    private void Start()
    {
        rb.gravityScale = 0;
    }

    private void Update()
    {
        movement();
    }
}
