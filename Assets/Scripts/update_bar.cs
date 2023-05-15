using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class update_bar : MonoBehaviour
{
    [SerializeField]
    float patience_time;

    [SerializeField]
    GameObject bar;

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

    IEnumerator decrease_bar()
    {
        coroutineRunning = true;
        while (dirty)
        {
            yield return new WaitForSeconds(1);
            float time = DecreaseLifePerSecond(maxTime, patience_time);
            bar.GetComponent<p_bar>().UpdatePBar(time);
            //Debug.Log("time is "+time);
        }
        coroutineRunning = false;
    }

    public float DecreaseLifePerSecond(float lifeBarFullCapacity, float timeToDecreaseInMinutes)
    {
        // Convert time to decrease from minutes to seconds
        float timeToDecreaseInSeconds = timeToDecreaseInMinutes * 60f;

        // Calculate how much to decrease the life bar each second
        float decreasePerSecond = lifeBarFullCapacity / timeToDecreaseInSeconds;

        return decreasePerSecond;
    }
}
