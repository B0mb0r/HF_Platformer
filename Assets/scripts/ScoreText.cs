using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    private TextMeshProUGUI text;

    // Use this for initialization
    void Start()
    {
        //Våran variabel kopplas till rätt text
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //Detta visar hur poängen skrivs ut på skärmen
        text.text = string.Format("Score: {0:0000}", Coin.score);
    }
}
