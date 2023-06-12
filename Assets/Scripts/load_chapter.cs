using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_chapter : MonoBehaviour
{
    [SerializeField]
    bool is_chapter = true;

    [SerializeField]
    string chapter_name;

    public void load_level()
    {
        SceneManager.LoadScene(chapter_name);
        Time.timeScale = 1f;
        if (is_chapter)
        {
            player_stats.current_day = chapter_name;
            player_stats.current_level_points = 0;
        }
    }
}
