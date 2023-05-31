using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class get_points : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text scoreText;
    string txt;
    string str;
    public bool update_player_score;
    public bool update_cable_speed;
    public bool score_num;

    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (update_player_score)
        {
            update_score();
        }
        if (update_cable_speed)
        {
            cable_speed_up();
        }
        if (score_num)
        {
            update_score_only_numbers();
        }
    }

    void update_score()
    {
        txt = "" + player_stats.score + " score";
        scoreText.text = txt;
    }

    void update_score_only_numbers()
    {
        scoreText.text = "" + player_stats.score;
    }

    void cable_speed_up()
    {
        txt = "" + player_stats.cable_speed_add + " cables speed up";
        scoreText.text = txt;
    }
}
