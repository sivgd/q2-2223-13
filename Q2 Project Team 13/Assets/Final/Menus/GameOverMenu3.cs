using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu3 : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("City");
    }
}