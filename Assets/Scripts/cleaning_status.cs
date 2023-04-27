using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cleaning_status : MonoBehaviour
{
    [SerializeField] GameObject mud;
    [SerializeField] GameObject bubbles;
    bool is_mud = true;
    bool is_bubbled = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "sponge" && is_mud ){
            mud.GetComponent<SpriteRenderer>().enabled = false;
            bubbles.GetComponent<SpriteRenderer>().enabled = true;
            is_mud = false;
            is_bubbled = true;
        }
        if(other.tag == "mop" && is_bubbled ){
            bubbles.GetComponent<SpriteRenderer>().enabled = false;
            is_mud = false;
            is_bubbled = false;
        }

    }
}
