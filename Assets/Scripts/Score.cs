using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int score;
    Text scoreText;

    int highScore;
    public Text highScoreText;


    private void Start()
    {
        score = 0;
        scoreText = GetComponent<Text>();
        scoreText.text = score.ToString();

        highScoreText = GetComponent<Text>();
        highScore = PlayerPrefs.GetInt("highScore");
        highScoreText.text = highScore.ToString();
    }

    public void Scored()
    {
        score++;
        scoreText.text = score.ToString();

        if (score > highScore)
        {
            HighScored();
        }
    }
    public void HighScored()
    {
        highScore = score;

        highScoreText.text = highScore.ToString();
        PlayerPrefs.SetInt("highScore", highScore);
    }
}
