using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //static gör att variabeln inte resettas när vi loadar en ny scen bara om vi stänger av spelet eller specifikt säger till den att göra det.
    public static int score;

    public int amount = 1;

    private float spinSpeed = 180;

    private void Update()
    {
        //Coinet roterar 
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Om spelaren colliderar med detta objektet händer något
        if(collision.tag == "Player")
        {
            //Poängen höjs med olika beroende på hur mycket "amount" är
            Coin.score += amount;
            //Coinet försvinner
            Destroy(gameObject);
        }
    }
}
