using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool isGrounded = false;
    [SerializeField] float jumpForce = 10f;
    private void Update()
    {
        Jump();
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }

    



    /*[SerializeField] private LayerMask platformLayerMask;
    private Rigidbody2D rigidbody2d;
    [SerializeField] float jumpVelocity = 10f;
    private CircleCollider2D circleCollider2d;

    private void Awake()
    {
        rigidbody2d = transform.GetComponent<Rigidbody2D>();
        circleCollider2d = transform.GetComponent<CircleCollider2D>();
    }

    private void Update()
    {
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
        }
    }*/






}



