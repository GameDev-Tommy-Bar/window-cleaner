using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class day_text_loader : MonoBehaviour
{
    [SerializeField]
    TMP_Text win_text;

    // Start is called before the first frame update
    void Start()
    {
        win_text.text =
            player_stats.current_day
            + " Finished!\nYou made "
            + player_stats.current_level_points
            + " points!";
    }

    // Update is called once per frame
    void Update() { }
}
