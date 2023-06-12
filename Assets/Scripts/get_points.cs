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
    public bool sponge;
    public bool mop;
    public bool dirty;

    public bool total_windows;

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
        if (total_windows)
        {
            windows_calculate();
        }
        if (sponge)
        {
            sponge_time();
        }
        if (mop)
        {
            mop_time();
        }
        if (dirty)
        {
            dirt_delay();
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

    void windows_calculate()
    {
        txt = "total " + player_stats.windows_cleand + " windows cleand";
        scoreText.text = txt;
    }

    void sponge_time()
    {
        txt = "" + player_stats.mud_fade_duration + " sponge cleaning duration";
        scoreText.text = txt;
    }

    void mop_time()
    {
        txt = "" + player_stats.bubbles_fade_duration + " mop cleaning duration";
        scoreText.text = txt;
    }

    void dirt_delay()
    {
        txt = "" + player_stats.dirt_delay + " dirt delay";
        scoreText.text = txt;
    }
}
