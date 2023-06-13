using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class upgrade_item : MonoBehaviour
{
    // this script handle the Power Ups upgrade shop
    public float cost_factor = 2f;
    public float amount_to_add = 0.1f;

    public void buy_cable_speed()
    {
        if (player_stats.score >= player_stats.speed_cost)
        {
            player_stats.cable_speed_add += amount_to_add;
            player_stats.score -= player_stats.speed_cost;
            player_stats.speed_cost += cost_factor;
        }
    }

    public void buy_sponge_speed()
    {
        if (player_stats.score >= player_stats.sponge_cost && player_stats.mud_fade_duration > 0.01)
        {
            player_stats.mud_fade_duration -= amount_to_add;
            player_stats.score -= player_stats.sponge_cost;
            player_stats.sponge_cost += cost_factor;
        }
    }

    public void buy_mop_speed()
    {
        if (
            player_stats.score >= player_stats.mop_cost && player_stats.bubbles_fade_duration > 0.01
        )
        {
            player_stats.bubbles_fade_duration -= amount_to_add;
            player_stats.score -= player_stats.mop_cost;
            player_stats.mop_cost += cost_factor;
        }
    }

    public void buy_dirt_slower()
    {
        if (player_stats.score >= player_stats.dirt_delay_cost)
        {
            player_stats.dirt_delay += amount_to_add;
            player_stats.score -= player_stats.dirt_delay_cost;
            player_stats.dirt_delay_cost += cost_factor;
        }
    }
}
