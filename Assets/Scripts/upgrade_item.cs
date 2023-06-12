using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class upgrade_item : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    TMP_Text cables_level;

    [SerializeField]
    TMP_Text sponge_level;

    [SerializeField]
    TMP_Text mop_level;

    public float cost = 1;
    float coins = player_stats.score;
    public float amount_to_add = 0.1f;

    public void buy_cable_speed()
    {
        if (player_stats.score >= cost)
        {
            player_stats.cable_speed_add += amount_to_add;
            player_stats.score -= cost;
            cables_level.text = "current: " + player_stats.cable_speed_add.ToString("F2");
        }
    }

    public void buy_sponge_speed()
    {
        if (player_stats.score >= cost && player_stats.mud_fade_duration > 0.01)
        {
            player_stats.mud_fade_duration -= amount_to_add;
            player_stats.score -= cost;
            sponge_level.text = "current: " + player_stats.mud_fade_duration.ToString("F2");
        }
    }

    public void buy_mop_speed()
    {
        if (player_stats.score >= cost && player_stats.bubbles_fade_duration > 0.01)
        {
            player_stats.bubbles_fade_duration -= amount_to_add;
            player_stats.score -= cost;
            mop_level.text = "current: " + player_stats.bubbles_fade_duration.ToString("F2");
        }
    }
}
