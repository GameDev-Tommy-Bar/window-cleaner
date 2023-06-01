using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puse_script : MonoBehaviour
{
    public GameObject pause_panel;
    public GameObject player;

    // Start is called before the first frame update
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

        //player.GetComponent<mover>().steps_sound.Play();
    }

    // Update is called once per frame
    void Update() { }
}
