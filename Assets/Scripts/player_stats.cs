using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class player_stats : MonoBehaviour
{
    // Start is called before the first frame update
    public static float score = 0;
    public static float cable_speed_add = 0;
    public static float mud_fade_duration = 1f;
    public static float bubbles_fade_duration = 1f;
    public static float current_level_points = 0;
    public static float windows_cleand = 0;
    public static float dirt_delay = 0;
    public static string current_day;
    public static int max_level = 1;
    public static bool[] lockArray = Enumerable.Repeat(true, 6).ToArray();

    public void change_score(float new_score)
    {
        score += new_score;
    }
}
