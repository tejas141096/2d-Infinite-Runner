using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUpScript : MonoBehaviour {
    
    int hsc = 0;

    void Start()
    {
        hsc = PlayerPrefs.GetInt("HighScore");
    }

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 70, 160, 140, 30), "!! INFINITY RUNNER !!");
        GUI.Label(new Rect(Screen.width / 2 - 60, 180, 160, 40), "HIGH SCORE: " + hsc);
        if (GUI.Button(new Rect(Screen.width / 2 - 60, 250, 100, 40), "Start"))
        {
            Application.LoadLevel(1);
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 60, 290, 100, 40), "Quit"))
        {
            Application.Quit();
        }
    }
}
