using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class point_adder : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    void Start()
    {
    }
    void Update()
    {
    }
    void add_score(){
            private int score;
            score = Int32.Parse(scoreText.text);
            score += 1;
            scoreText.text = score.ToString();
    }
}
