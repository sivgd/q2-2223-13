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
        //tmpHealth.text = playerHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth > 100)
        {


            playerHealth = 100;
        }
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
        else if (percentHealth < 0)
        {
            sr.color = Color.black;
            isAlive = false;

        }

        
    }
    


    // private void OnTriggerEnter2D(Collider2D other)
    // {
    // if (other.gameObject.tag == "Salt Water")
    // {
    // playerHealth -= 1;


    // }
    // }




}
