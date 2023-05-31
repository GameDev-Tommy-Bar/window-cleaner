using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upgrade_item : MonoBehaviour
{
    // Start is called before the first frame update
    public int cost = 1;
    float coins = player_stats.score;
    public float amount_to_add = 0.1f;

    void buy()
    {
        if (player_stats.score >= cost)
        {
            player_stats.cable_speed_add += amount_to_add;
        }
    }
}
