using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizMovement : MonoBehaviour
{
    public float speed = 2f;
    public float xSize;
    public bool Left = true;

    public GroundChecker check;

    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        //Våran variabel kopplas till rätt Rigidbody
        rbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //Om råttan kollar vänster så händer något
        if (Left == true)
        {
            //Råttan sätts i rörelse i vänster riktning
            rbody.velocity = -(Vector2)transform.right * speed;
            //Råttan kollar åt vänster
            transform.localScale = new Vector3(xSize, transform.localScale.y, transform.localScale.z);
        }
        //Om råttan inte kollar vänster händer något annat
        else
        {
            //Råttan sätts i rörelse i höger riktning
            rbody.velocity = (Vector2)transform.right * speed;
            //Råttan kollar åt höger (men byter inte storlek till en mindre om den är större än orginalet)
            transform.localScale = new Vector3(-xSize, transform.localScale.y, transform.localScale.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om råttan nuddar en vägg med taggen "InvisibleWall" så händer något
        if (collision.tag == "InvisibleWall")
        {
            //Våran variabel som kollar vilken riktning råttan kollar byter riktning
            Left = !Left;
        }
    }
}
