using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lock_manager : MonoBehaviour
{
    // this script used for handle the level locks
    [SerializeField]
    GameObject lock2;

    [SerializeField]
    GameObject lock3;

    [SerializeField]
    GameObject lock4;

    [SerializeField]
    GameObject lock5;

    [SerializeField]
    GameObject lock6;

    // Start is called before the first frame update
    void Start()
    {
        lock2.SetActive(player_stats.lockArray[1]);
        lock3.SetActive(player_stats.lockArray[2]);
        lock4.SetActive(player_stats.lockArray[3]);
        lock5.SetActive(player_stats.lockArray[4]);
        lock6.SetActive(player_stats.lockArray[5]);
    }

    // Update is called once per frame
    void Update() { }
}
