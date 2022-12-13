using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public int playerHealth;
    public int maxHealth;
    public float yellowZone;
    public float redZone;
    public bool isAlive;
    SpriteRenderer sr;
    public TMP_Text tmpHealth;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = Color.green;
        tmpHealth.text = playerHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage()
    {

        playerHealth--;
        tmpHealth.text = playerHealth.ToString();
        float percentHealth = (float)playerHealth / (float)maxHealth;
        if (percentHealth > yellowZone)
        {
            sr.color = Color.green;
        }
        else if (percentHealth < yellowZone && percentHealth > redZone)
        {

            sr.color = Color.yellow;

        }
        else if (percentHealth < yellowZone && percentHealth > 0)
        {

            sr.color = Color.red;
        }
        else
        {
            sr.color = Color.black;
            isAlive = false;

        }


    }


}
