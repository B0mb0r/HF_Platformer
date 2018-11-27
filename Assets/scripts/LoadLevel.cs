using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    public int minimumScoreNeeded;

    public string sceneToLoad = "SampleScene";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Monedas.score >= minimumScoreNeeded)
        {
            Monedas.score = 0;
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
