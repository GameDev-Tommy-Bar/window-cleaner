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
    public bool shop_show_mop;
    public bool shop_show_sponge;
    public bool shop_show_speed;
    public bool shop_show_dirt;
    public bool dirt_cost_text;
    public bool mop_cost_text;
    public bool sponge_cost_text;
    public bool speed_cost_text;

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
        if (shop_show_sponge)
        {
            shop_sponge();
        }
        if (shop_show_mop)
        {
            shop_mop();
        }
        if (shop_show_speed)
        {
            shop_speed();
        }
        if (shop_show_dirt)
        {
            shop_dirt();
        }
        if (speed_cost_text)
        {
            cost_speed();
        }
        if (sponge_cost_text)
        {
            cost_sponge();
        }
        if (mop_cost_text)
        {
            cost_mop();
        }
        if (dirt_cost_text)
        {
            cost_dirt();
        }
    }

    void update_score()
    {
        txt = "" + player_stats.score + " score";
        scoreText.text = txt;
    }

    void update_score_only_numbers()
    {
        scoreText.text = "" + player_stats.score + "$";
    }

    void cable_speed_up()
    {
        txt = "" + player_stats.cable_speed_add.ToString("f2") + " cables speed up";
        scoreText.text = txt;
    }

    void windows_calculate()
    {
        txt = "total " + player_stats.windows_cleand + " windows cleand";
        scoreText.text = txt;
    }

    void sponge_time()
    {
        txt = "" + player_stats.mud_fade_duration.ToString("f2") + " sponge cleaning duration";
        scoreText.text = txt;
    }

    void mop_time()
    {
        txt = "" + player_stats.bubbles_fade_duration.ToString("f2") + " mop cleaning duration";
        scoreText.text = txt;
    }

    void dirt_delay()
    {
        txt = "" + player_stats.dirt_delay.ToString("f2") + " dirt delay";
        scoreText.text = txt;
    }

    void shop_mop()
    {
        txt = "current " + player_stats.bubbles_fade_duration.ToString("f2");
        scoreText.text = txt;
    }

    void shop_sponge()
    {
        txt = "current " + player_stats.mud_fade_duration.ToString("f2");
        scoreText.text = txt;
    }

    void shop_speed()
    {
        txt = "current " + player_stats.cable_speed_add.ToString("f2");
        scoreText.text = txt;
    }

    void shop_dirt()
    {
        txt = "current " + player_stats.dirt_delay.ToString("f2");
        scoreText.text = txt;
    }

    void cost_mop()
    {
        txt = "cost " + player_stats.mop_cost.ToString();
        scoreText.text = txt;
    }

    void cost_sponge()
    {
        txt = "cost " + player_stats.sponge_cost.ToString();
        scoreText.text = txt;
    }

    void cost_speed()
    {
        txt = "cost " + player_stats.speed_cost.ToString();
        scoreText.text = txt;
    }

    void cost_dirt()
    {
        txt = "cost " + player_stats.dirt_delay_cost.ToString();
        scoreText.text = txt;
    }
}
