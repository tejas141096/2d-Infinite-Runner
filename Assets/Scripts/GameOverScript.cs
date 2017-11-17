using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour {

    int score = 0;
    int hsc = 0;
    
	void Start () {
        score = PlayerPrefs.GetInt("Score");
        hsc = PlayerPrefs.GetInt("HighScore");
	}

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width/2-50,160,100,30),"GAME OVER");
        GUI.Label(new Rect(Screen.width /2-60, 180, 160, 40), "HIGH SCORE: "+hsc);
        GUI.Label(new Rect(Screen.width/2-50,200,100,40), "SCORE: "+ score);
        if (GUI.Button(new Rect(Screen.width/2-100,250,100,40), "Retry"))
        {
            Application.LoadLevel(1);
        }
        if (GUI.Button(new Rect(Screen.width / 2, 250, 100, 40), "Main Menu"))
        {
            Application.LoadLevel(0);
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 60, 290, 100, 40), "Quit"))
        {
                Application.Quit();
        }
    }
}
