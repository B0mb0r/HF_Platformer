using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizMovement : MonoBehaviour
{
    public float speed = 2f;
    public bool Left = true;

    public GroundChecker check;

    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Left == true)
        {
            rbody.velocity = -(Vector2)transform.right * speed;
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            rbody.velocity = (Vector2)transform.right * speed;
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InvisibleWall")
        {
            Left = !Left;
        }
    }
}
