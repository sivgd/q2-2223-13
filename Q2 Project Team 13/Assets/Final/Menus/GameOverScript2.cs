using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript2 : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("xavierscene");
    }
}
