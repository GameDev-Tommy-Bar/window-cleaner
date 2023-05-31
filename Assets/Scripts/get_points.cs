using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class get_points : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text scoreText;
    void Start()
    {
        scoreText.text = player_stats.score + " coins";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
