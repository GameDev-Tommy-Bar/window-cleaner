using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
this func is used to check if all windows are cleaned
*/
public class p_bar : MonoBehaviour
{
    [SerializeField]
    public Slider slider;

    public void UpdatePBar(float decrease_factor)
    {
        if (enabled)
        {
            slider.value -= decrease_factor;
        }
    }

    public float getMaxValue()
    {
        return slider.maxValue;
    }

    public void increaseBar(float increase_factor)
    {
        if (enabled)
        {
            slider.value += increase_factor;
        }
    }

    public void increaseFull()
    {
        slider.value = slider.maxValue;
    }

    // Start is called before the first frame update
    void Start()
    {
        //UpdatePBar(100);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        //val = slider.value;
        //Debug.Log("val: "+val);
    }
}
