
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinalCutscene : MonoBehaviour
{
    private static int nScreens = 5;
    private GameObject[] creditScreens = new GameObject[nScreens];
    private static int swapCount = 0;


    // Use this for initialization
    void Start()
    {
        //For each credit screen, add a new reference here:
        creditScreens[0] = GameObject.Find("1");
        creditScreens[1] = GameObject.Find("2");
        creditScreens[2] = GameObject.Find("3");
        creditScreens[3] = GameObject.Find("4");
        creditScreens[4] = GameObject.Find("Sceneswitch");

        //Turn them all off...
        for (int i = 0; i < nScreens; i++)
        {
            creditScreens[i].SetActive(false);
        }
        //Except, turn back on element 0
        creditScreens[0].SetActive(true);
    } //Start

    int counter = 0;

    public void OnGUI()
    {
        //if (GUI.Button(new Rect(100, 100, 200, 50), "Count: " + counter))
        //{ // the IF is true = clicked, lets count one
        //counter++;
        //}
    }



    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            counter++;
            //Toggle
            int currentScene = swapCount % nScreens;
            creditScreens[currentScene].SetActive(false);
            swapCount++;
            currentScene = swapCount % nScreens;
            creditScreens[currentScene].SetActive(true);


        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Switch scene");
            SceneManager.LoadScene("L1");
        }
        if (counter == 4)
        {

            Debug.Log("Switch scene");
            SceneManager.LoadScene("StartGameSceneFixed");



        }
    } ////Update

}




