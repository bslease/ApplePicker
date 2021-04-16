using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    // making score public and static gives us the ability
    // to access it from any other script like so: HighScore.score
    static public int score = 1000;

    private void Awake()
    {
        // If the PlayerPrefs HighScore already exists, read it
        if (PlayerPrefs.HasKey("HighScore"))
        {
            score = PlayerPrefs.GetInt("HighScore");
        }
        // Assign the high score to HighScore
        // (this seems unnecessary)
        PlayerPrefs.SetInt("HighScore", score);
    }

    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " + score;
        //Update the PlayerPrefs HighScore if necessary
        if (score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
