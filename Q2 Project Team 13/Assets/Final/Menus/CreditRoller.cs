using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditRoller : MonoBehaviour
{
    private static int nScreens = 5;
    private GameObject[] creditScenes = new GameObject[nScreens];
    private static int swapCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        //For each credit scene, add a reference here:
        creditScenes[0] = GameObject.Find("Credit1");
        creditScenes[1] = GameObject.Find("Credit2");
        creditScenes[2] = GameObject.Find("Credit3");
        creditScenes[3] = GameObject.Find("Credit4");
        creditScenes[4] = GameObject.Find("Credit5");

        //Turn all scenes off
        for (int i = 0; i < nScreens; i++)
        {
            creditScenes[i].SetActive(false);
        }
        //Turn back on the "0th"
        creditScenes[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            int CurrentScene = swapCount % nScreens;
            creditScenes[CurrentScene].SetActive(false);
            swapCount++;
            CurrentScene = swapCount % nScreens;
            creditScenes[CurrentScene].SetActive(true);
        }
    }
}
