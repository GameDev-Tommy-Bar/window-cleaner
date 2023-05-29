using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

/*
this func is used to control the patience slider bar
*/
public class p_bar : MonoBehaviour
{
    public Slider slider;
    public GameObject gameover;
    public TMP_Text score_text;

    /*
        this method used to decrease the bar level
    */
    public void UpdatePBar(float decrease_factor)
    {
        if (enabled)
        {
            slider.value -= decrease_factor;
        }
    }

    /*
        this method used to get the bar maximum level
    */
    public float getMaxValue()
    {
        return slider.maxValue;
    }

    /*
        this method used to increase the bar level
    */
    public void increaseBar(float increase_factor)
    {
        if (enabled)
        {
            slider.value += increase_factor;
        }
    }

    /*
        this method used to fill up the bar
    */
    public void increaseFull()
    {
        slider.value = slider.maxValue;
    }

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (slider.value == 0)
        {
            onEnd();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void onEnd()
    {
        int score = Int32.Parse(score_text.text);
        gameover.SetActive(true);
        gameover.GetComponent<GameOverScript>().Setup(score);

    }
}
