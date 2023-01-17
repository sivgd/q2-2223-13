using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour
{

    public GameObject Frog;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Frog.GetComponent<PlayerStats>().TakeDamage(5);
    }
}
