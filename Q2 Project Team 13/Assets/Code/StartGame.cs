using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "")
        {
            Debug.Log("Switch scene");
            SceneManager.LoadScene("Game");
        }
    }

}