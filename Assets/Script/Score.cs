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
    public Text panelScore;
    void Start()
    {
        score = 0;
        scoreText = GetComponent<Text>();
        scoreText.text=score.ToString();
        panelScore.text=score.ToString();
        highScore = PlayerPrefs.GetInt("highscore");
        highScoreText.text=highScore.ToString();
    }

    public void Scored()
    {
        score++;
        scoreText.text=score.ToString();
        panelScore.text = score.ToString();
        if (score>highScore)
        {
            highScore = score;
            highScoreText.text = highScore.ToString();
            PlayerPrefs.SetInt("highscore" ,highScore);
        }

    }

    void Update()
    {
        
    }
}
