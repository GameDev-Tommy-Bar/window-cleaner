using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    /*
        this script controll the time it take for each building's window to get dirty again.
    */
    // Start is called before the first frame update
    public float time_between_dirt;

    [SerializeField]
    float min_time = 0;

    [SerializeField]
    float max_time = 0;

    //random time between
    public float get_time()
    {
        time_between_dirt = Random.Range(min_time, max_time);
        return time_between_dirt;
    }
}
