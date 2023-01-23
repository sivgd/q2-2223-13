using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public int playerHealth;
    public int maxHealth;
    public GameObject HealthBar;
    public Rigidbody2D rb2;
    public GameObject Player;
    Animator a;

    //public float yellowZone;
    // public float redZone;
    public bool isAlive;
    SpriteRenderer sr;
    public TMP_Text tmpHealth;
    public bool isHurt;
    
   
    // Start is called before the first frame update
    void Start()
    {
        //  sr = GetComponent<SpriteRenderer>();
        //  sr.color = Color.green;
        //tmpHealth.text = playerHealth.ToString();
        //TakeDamage(30);
        rb2 = GetComponent<Rigidbody2D>();
        gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth > 100)
        {


            playerHealth = 100;
        }
        ChangeHealthBar();

        if (playerHealth <= 0)
        {

            isAlive = false;

        }


        if(isAlive == false)
        {
            //a.SetBool("isAlive", false);
            GetComponent<MOve>().enabled = false;
            GetComponent<Hop>().enabled = false;
            GetComponent<Grappler>().enabled = false;
            GetComponent<CopyOfWallCliming>().enabled = false;
            Invoke("SwitchScene", 5);
           

        }
        else
        {
          //  a.SetBool("isAlive", true);

        }

    }

    public void TakeDamage()
    {

        playerHealth--;
        //tmpHealth.text = playerHealth.ToString();
        float percentHealth = (float)playerHealth / (float)maxHealth;
        ChangeHealthBar();
      //  Debug.Log("Knockback");
       // rb2.AddForce(new Vector2(-13, 0));
       // GetComponent<MOve>().enabled = false;
       // GetComponent<Hop>().enabled = false;
      //  GetComponent<Grappler>().enabled = false;
      //  GetComponent<CopyOfWallCliming>().enabled = false;
       // isHurt = true;
       // Invoke("EnableMovement", 1);

        //if (percentHealth > yellowZone)
      //  {
        //    sr.color = Color.green;
       // }
       // else if (percentHealth < yellowZone && percentHealth > redZone)
       // {

         //   sr.color = Color.yellow;

      //  }
       // else if (percentHealth < yellowZone && percentHealth > 0)
      //  {

       //     sr.color = Color.red;
       // }
      //  else if (percentHealth < 0)
     //   {
      //      sr.color = Color.black;
       //     isAlive = false;

      //  }

        
    }

    public void TakeDamage(int amountOfDamage)
    {

        playerHealth-=amountOfDamage;
        // tmpHealth.text = playerHealth.ToString();
        GetComponent<MOve>().enabled = false;
        GetComponent<Hop>().enabled = false;
        GetComponent<Grappler>().enabled = false;
        GetComponent<CopyOfWallCliming>().enabled = false;
        Player.GetComponent<Rigidbody2D>().AddForce(new Vector2(10, 20), ForceMode2D.Impulse);
      Debug.Log("Knockback");
        isHurt = true;
       // a.SetBool("isHurt", true);
        Invoke("EnableMovement", 2);
        ChangeHealthBar();
    }


    // private void OnTriggerEnter2D(Collider2D other)
    // {
    // if (other.gameObject.tag == "Salt Water")
    // {
    // playerHealth -= 1;


    // }
    // }

    public void ChangeHealthBar()
    {
        HealthBar.GetComponent<HealthBarMask>().MoveMask(playerHealth, maxHealth);
    }


    private void EnableMovement()
    {

        GetComponent<MOve>().enabled = true;
        GetComponent<Hop>().enabled = true;
        GetComponent<Grappler>().enabled = true;
        GetComponent<CopyOfWallCliming>().enabled = true;

        isHurt = false;
       // a.SetBool("isHurt", false);
    }

    private void SwitchScene()
    {

        Debug.Log("Switchscene");

    }

}
