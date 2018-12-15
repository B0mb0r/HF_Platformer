using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killBoss : MonoBehaviour
{
    public float bossHP = 6;

    public GameObject spawnObject;
    public Transform[] spawnPoints;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om något med taggen player nuddar detta objekt så händer något.
        if (collision.tag == "Player")
        {
            bossHP = bossHP - 1;  
            print("hit");
        }
        if (bossHP == 0)
        {
            Destroy(gameObject);
            Instantiate(spawnObject, spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);
        }
    }
}
