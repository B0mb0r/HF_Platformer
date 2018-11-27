using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setSpriteInvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
