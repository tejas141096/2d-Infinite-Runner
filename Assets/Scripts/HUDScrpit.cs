using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDScrpit : MonoBehaviour {

    public float playerScore = 0;
    int hsc;

    void Start()
    {
        hsc = PlayerPrefs.GetInt("HighScore");
    }

    // Update is called once per frame
    void Update () {
        playerScore += Time.deltaTime;
	}

    public void IncreaseScore(int amount)
    {
        playerScore += amount;
    }

    void OnDisable()
    {
        if (hsc < ((int)(playerScore*100)))
        {
            PlayerPrefs.SetInt("HighScore", (int)(playerScore * 100));
        }
        PlayerPrefs.SetInt("Score", (int)(playerScore*100));
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 60), "Score: " + (int)(playerScore * 100));
    }
}
