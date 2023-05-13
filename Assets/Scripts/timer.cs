using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    // Start is called before the first frame update
[SerializeField] float time_between_dirt = 2;
public float get_time(){
    return time_between_dirt;
}
}
