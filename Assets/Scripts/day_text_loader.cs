using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text.RegularExpressions;

public class day_text_loader : MonoBehaviour
{
    // this script used for set the text and unlock level when the end day screen appear
    [SerializeField]
    TMP_Text win_text;

    // Start is called before the first frame update
    void Start()
    {
        player_stats.lockArray[0] = false; // set the first lock to false -- level 1 open
        win_text.text =
            player_stats.current_day
            + " Finished!\nYou made "
            + player_stats.current_level_points
            + " points!";
        string numberString = Regex.Match(player_stats.current_day, @"\d+").Value;
        int number = int.Parse(numberString);
        if (player_stats.lockArray[number] == true)
        {
            Debug.Log("new level unlock " + (number + 1));
            player_stats.lockArray[number] = false;
        }
    }

    // Update is called once per frame
    void Update() { }
}
