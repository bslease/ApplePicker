using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    // making score public and static gives us the ability
    // to access it from any other script like so: HighScore.score
    static public int score = 1000;

    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score " + score;
    }
}
