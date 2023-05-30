using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
this script is used to call the p_bar script and integrate between the patience bar and the buildings windows
*/
public class update_bar : MonoBehaviour
{
    [SerializeField]
    float patience_time;

    [SerializeField]
    GameObject bar;

    [SerializeField]
    float time_to_wait = 1f;

    [SerializeField]
    GameObject windows_manager;
    bool dirty = true;
    float maxTime;
    bool coroutineRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(decrease_bar());
        maxTime = bar.GetComponent<p_bar>().getMaxValue();
        Debug.Log("maxTIME is " + maxTime);
    }

    // Update is called once per frame
    void Update()
    {
        dirty = !windows_manager.GetComponent<all_clean>().all_cleaned;
        //Debug.Log("they dirty? "+dirty );
        //bar.GetComponent<p_bar>().UpdatePBar(0.1f);
        if (dirty && !coroutineRunning)
        {
            StartCoroutine(decrease_bar());
        }
    }

    /*
        this method used to decrease the bar every one second when windows are dirty
    */
    IEnumerator decrease_bar()
    {
        coroutineRunning = true;
        while (dirty)
        {
            yield return new WaitForSeconds(time_to_wait);
            float time = DecreaseLifePerSecond(maxTime, patience_time);
            bar.GetComponent<p_bar>().UpdatePBar(time);
            //Debug.Log("time is "+time);
        }
        coroutineRunning = false;
    }

    /*
        this method is helper method to calculate the amount of value to decrease from patience bar
    */
    public float DecreaseLifePerSecond(float lifeBarFullCapacity, float timeToDecreaseInSeconds)
    {
        // Convert time to decrease from minutes to seconds

        // Calculate how much to decrease the life bar each second
        float decreasePerSecond = lifeBarFullCapacity / timeToDecreaseInSeconds;

        return decreasePerSecond;
    }
}
