using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    /*
        this script controll the time it take for each building's window to get dirty again.
    */
    // Start is called before the first frame update

    [SerializeField]
    float time = 3;

    //random time between
    public float get_time()
    {
        return time + player_stats.dirt_delay;
    }
}
