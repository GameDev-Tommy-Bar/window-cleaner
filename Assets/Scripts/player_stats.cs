using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_stats : MonoBehaviour
{
    // Start is called before the first frame update
    public static float score = 0;
    public static float cable_speed_add = 0;
    public static float mud_fade_duration = 1f;
    public static float bubbles_fade_duration = 1f;
    public static float current_level_points = 0;
    public static string current_day;

    public void change_score(float new_score)
    {
        score += new_score;
    }
}
