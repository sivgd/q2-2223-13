using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckForPlayerCollision : MonoBehaviour
{
    public GameObject spawnpoint;
    public GameObject mainPlayer;
    private Rigidbody2D rb2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            rb2 = mainPlayer.GetComponent<Rigidbody2D>();
            rb2.velocity = new Vector2(0, 0);
            mainPlayer.GetComponent<PlayerStats>().TakeDamage(5);
        }
        if ( mainPlayer.GetComponent<PlayerStats>().playerHealth == 0)
        {
            //mainPlayer.transform.localPosition = spawnpoint.transform.localPosition;
            SceneManager.LoadScene("GameOverScene");
        }
        if (mainPlayer.GetComponent<PlayerStats>().playerHealth == 0)
        {
            mainPlayer.GetComponent<PlayerStats>().playerHealth = 100;
        }
    }

}
