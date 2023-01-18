using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("L1");
    }
    public void ShowCredits()
    {
        SceneManager.LoadScene("CreditScene");
    }
}
