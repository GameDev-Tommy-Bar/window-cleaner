using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class upgrade_item : MonoBehaviour
{
    // this script handle the Power Ups upgrade shop
    public float cost_factor = 2f;
    public float amount_to_add = 0.1f;
    float sponge_counter = 0f;
    float speed_counter = 0f;
    float dirt_counter = 0f;
    float mop_counter = 0f;
    public float increase_rate = 5;

    public void buy_cable_speed()
    {
        if (player_stats.score >= player_stats.speed_cost)
        {
            speed_counter++;
            player_stats.cable_speed_add += amount_to_add;
            player_stats.score -= player_stats.speed_cost;
            if (speed_counter % increase_rate == 0)
            {
                player_stats.speed_cost += cost_factor;
            }
        }
    }

    public void buy_sponge_speed()
    {
        if (player_stats.score >= player_stats.sponge_cost && player_stats.mud_fade_duration > 0.01)
        {
            sponge_counter++;
            player_stats.mud_fade_duration -= amount_to_add;
            player_stats.score -= player_stats.sponge_cost;
            if (sponge_counter % increase_rate == 0)
            {
                player_stats.sponge_cost += cost_factor;
            }
        }
    }

    public void buy_mop_speed()
    {
        if (
            player_stats.score >= player_stats.mop_cost && player_stats.bubbles_fade_duration > 0.01
        )
        {
            mop_counter++;
            player_stats.bubbles_fade_duration -= amount_to_add;
            player_stats.score -= player_stats.mop_cost;
            if (mop_counter % increase_rate == 0)
            {
                player_stats.mop_cost += cost_factor;
            }
        }
    }

    public void buy_dirt_slower()
    {
        if (player_stats.score >= player_stats.dirt_delay_cost)
        {
            dirt_counter++;
            player_stats.dirt_delay += amount_to_add;
            player_stats.score -= player_stats.dirt_delay_cost;
            if (dirt_counter % increase_rate == 0)
            {
                player_stats.dirt_delay_cost += cost_factor;
            }
        }
    }
}
