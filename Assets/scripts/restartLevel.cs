using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartLevel : MonoBehaviour
{
    public string sceneToLoad = "SampleScene";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om något med taggen player nuddar detta objekt så händer något.
        if (collision.tag == "Player")
        {
            //Våra poäng sätts till 0
            Coin.score = 0;
            //Vi laddar om banan så vi kan köra igen
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
