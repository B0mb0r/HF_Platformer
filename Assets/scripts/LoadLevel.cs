﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public string sceneToLoad = "SampleScene";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            print("triggerEnter");
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
