using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class update_shop_text : MonoBehaviour
{
    public TMP_Text txt;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    public void add_pow()
    {
        float amount = player_stats.cable_speed_add;
        txt.text = "current: " + amount;
    }
}
