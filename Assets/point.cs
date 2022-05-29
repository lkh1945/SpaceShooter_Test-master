using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class point : MonoBehaviour
{
    public int score;
    public Text point_text;
    void Start()
    {
        score = 0;
    }

    public void PlusScore()
    {
        score++;
    }
    void Update()
    {
        point_text.text = score.ToString();
    }
}
