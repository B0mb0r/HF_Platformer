using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killBoss : MonoBehaviour
{
    public float bossHP = 6;

    //När vi kommer i kontakt med något så händer något
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om något med taggen player nuddar detta objekt så händer något.
        if (collision.tag == "Player")
        {
            bossHP = bossHP - 1;
        }
        if (bossHP == 0)
        {
            Destroy(gameObject);
        }
    }
}
