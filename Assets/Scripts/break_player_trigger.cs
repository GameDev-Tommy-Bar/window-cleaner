using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class break_player_trigger : MonoBehaviour
{
    float y_pos;
    float z_pos;
    float x_pos;
    float left_lim = -2.2f;
    float right_lim = 2.5f;
    float buttom_lim = -4.25f;
    float top_lim = 5f;
    Vector3 new_pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag =="right") {
            y_pos = transform.position.y;
            z_pos = transform.position.z;
            new_pos = new Vector3(right_lim,y_pos,z_pos);
            transform.position = new_pos;
        }
        if(other.tag =="left") {
            y_pos = transform.position.y;
            z_pos = transform.position.z;
            new_pos = new Vector3(left_lim,y_pos,z_pos);
            transform.position = new_pos;
        }
            if(other.tag =="bottom") {
            x_pos = transform.position.x;
            z_pos = transform.position.z;
            new_pos = new Vector3(x_pos,buttom_lim,z_pos);
            transform.position = new_pos;
        }
            if(other.tag =="top") {
            x_pos = transform.position.x;
            z_pos = transform.position.z;
            new_pos = new Vector3(x_pos,top_lim,z_pos);
            transform.position = new_pos;
        }

    }
}

