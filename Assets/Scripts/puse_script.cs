using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puse_script : MonoBehaviour
{
    // this script handle the pause screen
    public GameObject pause_panel;
    public GameObject player;

    public void Pause()
    {
        pause_panel.SetActive(true);
        Time.timeScale = 0f;
        player.GetComponent<mover>().building_sound.Pause();
    }

    public void Continue()
    {
        pause_panel.SetActive(false);
        Time.timeScale = 1f;
    }
}
