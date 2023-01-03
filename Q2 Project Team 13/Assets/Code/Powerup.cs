using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public PowerupEffect powerupEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        //check here for player
        powerupEffect.Apply(collision.gameObject);
        Destroy(gameObject);
    }

}
