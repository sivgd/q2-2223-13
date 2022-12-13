using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject player;
    public void DealDamage()
    {

        Debug.Log("Owie");
        player.GetComponent<PlayerStats>().TakeDamage();

    }

}
