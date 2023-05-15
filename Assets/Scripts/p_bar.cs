using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class p_bar : MonoBehaviour
{
    [SerializeField]
    public Slider slider;

    public void UpdatePBar(float decrease_factor)
    {
        slider.value -= decrease_factor;
        Debug.Log("bar level is " + slider.value);
    }

    public float getMaxValue()
    {
        return slider.maxValue;
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