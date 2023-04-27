using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class items_change : MonoBehaviour
{
    [SerializeField] GameObject mop;
    [SerializeField] GameObject sponge;

    // Start is called before the first frame update
    void Start()
    {
        mop.GetComponent<SpriteRenderer>().enabled = false;
        sponge.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Z)){
            mop.GetComponent<SpriteRenderer>().enabled = false;
            sponge.GetComponent<SpriteRenderer>().enabled = false;
            mop.GetComponent<CircleCollider2D>().enabled = false;
            sponge.GetComponent<CapsuleCollider2D>().enabled = false;

        }
        if(Input.GetKey(KeyCode.X)){
            mop.GetComponent<SpriteRenderer>().enabled = false;
            sponge.GetComponent<SpriteRenderer>().enabled = true;
            mop.GetComponent<CircleCollider2D>().enabled = false;
            sponge.GetComponent<CapsuleCollider2D>().enabled = true;
        }
        if(Input.GetKey(KeyCode.C)){
            mop.GetComponent<SpriteRenderer>().enabled = true;
            sponge.GetComponent<SpriteRenderer>().enabled = false;
            mop.GetComponent<CircleCollider2D>().enabled = true;
            sponge.GetComponent<CapsuleCollider2D>().enabled = false;
        }

    }
}

