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

    [SerializeField]
    GameObject level_lock;

    public void load_level()
    {
        if (is_chapter)
        {
            if (!level_lock.activeSelf)
            {
                player_stats.current_day = chapter_name;
                player_stats.current_level_points = 0;
                SceneManager.LoadScene(chapter_name);
                Time.timeScale = 1f;
            }
        }
        else
        {
            SceneManager.LoadScene(chapter_name);
            Time.timeScale = 1f;
        }
    }
}
