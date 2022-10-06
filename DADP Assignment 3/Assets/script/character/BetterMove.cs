using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterMove : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;
    public Animator anim;

    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        anim.SetFloat("Player speed", movement.sqrMagnitude);


        if (Input.GetKey("d"))
        {
            gameObject.transform.localScale = new Vector3(1.5f, 1.5f, 1);
        }
        if (Input.GetKey("a"))
        {
            gameObject.transform.localScale = new Vector3(-1.5f, 1.5f, 1);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
