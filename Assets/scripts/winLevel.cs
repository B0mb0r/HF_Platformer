using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winLevel : MonoBehaviour
{
    public int minimumScoreNeeded;

    public string sceneToLoad = "SampleScene";

    //När vi kommer i kontakt med något så händer något
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om något med taggen player nuddar oss och har tillräckligt med poäng så händer något.
        if (collision.tag == "Player" && Coin.score >= minimumScoreNeeded)
        {
            //Våra poäng sätts till 0
            Coin.score = 0;
            //Vi laddar om banan så vi kan köra igen
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
