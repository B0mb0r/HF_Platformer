using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setSpriteInvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //När spelet startar så blir sprites med detta script osynliga.
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
