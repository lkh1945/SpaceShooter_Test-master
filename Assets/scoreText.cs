using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreText : MonoBehaviour
{
    public int score;
    Text score_Text;
    public void Awake()
    {
        score = 0;
        score_Text = GetComponent<Text>();
    }
    public void AddScore(int addScore)
    {
        score += addScore;
        score_Text.text = score.ToString();
    }
}
