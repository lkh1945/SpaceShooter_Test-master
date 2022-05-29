using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float score, shootChance, hit;
    public float sum;

    public int enemyCount, bossCount;
    public Text scoreText, hitText;
    void Start()
    {
        scoreText = scoreText.GetComponent<Text>();
        hitText = hitText.GetComponent<Text>();
        score = 0;
        shootChance = 0;
        hit = 0;
        sum = 0;
        scoreText.text = score.ToString();
        hitText.text = sum.ToString();
    }
    void Update()
    {
        if (shootChance == 0) sum = 0;
        else sum = (hit / shootChance * 100);
        hitText.text = sum.ToString("F1");
        scoreText.text = score.ToString();
    }
}
