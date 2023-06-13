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
    public GameObject smile_boss;
    public GameObject regular_boss;
    public GameObject angry_boss;

    public Slider slider;
    public GameObject gameover;
    public TMP_Text score_text;
    float slider_val;

    /*
        this method used to decrease the bar level
    */
    public void UpdatePBar(float decrease_factor)
    {
        if (enabled)
        {
            Debug.Log("slide value is " + slider.value);
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
            if (!(slider.value + increase_factor >= slider.maxValue))
            {
                slider.value += increase_factor;
            }
            else
            {
                slider.value = slider.maxValue;
            }
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
        boss_change();
    }

    private void onEnd()
    {
        string scoreText = score_text.text;
        int score = Int32.Parse(scoreText.Substring(0, scoreText.Length - 1));
        gameover.SetActive(true);
        gameover.GetComponent<GameOverScript>().Setup(score);
    }

    void boss_change()
    {
        slider_val = slider.value / slider.maxValue;
        if (slider_val >= 0.8 && !smile_boss.activeSelf)
        {
            smile_boss.SetActive(true);
            regular_boss.SetActive(false);
            angry_boss.SetActive(false);
        }
        if (slider_val < 0.8 && slider_val >= 0.5 && !regular_boss.activeSelf)
        {
            smile_boss.SetActive(false);
            regular_boss.SetActive(true);
            angry_boss.SetActive(false);
        }
        if (slider_val < 0.4 && !angry_boss.activeSelf)
        {
            smile_boss.SetActive(false);
            regular_boss.SetActive(false);
            angry_boss.SetActive(true);
        }
    }
}
