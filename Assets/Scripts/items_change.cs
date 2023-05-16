using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    * This script is used to control the items change
*/
public class items_change : MonoBehaviour
{
    [SerializeField]
    GameObject mop;

    [SerializeField]
    GameObject sponge;

    [SerializeField]
    GameObject bag;

    // Start is called before the first frame update
    void Start()
    {
        mop.GetComponent<SpriteRenderer>().enabled = false;
        sponge.GetComponent<SpriteRenderer>().enabled = false;
        bag.GetComponent<SpriteRenderer>().enabled = false;
    }

    /*
        * This function is used to check if the player presses the key
        * If the player presses the key, the corresponding item will appear
    */
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            mop.GetComponent<SpriteRenderer>().enabled = false;
            sponge.GetComponent<SpriteRenderer>().enabled = false;
            mop.GetComponent<CircleCollider2D>().enabled = false;
            sponge.GetComponent<CapsuleCollider2D>().enabled = false;
            bag.GetComponent<SpriteRenderer>().enabled = false;
            bag.GetComponent<CapsuleCollider2D>().enabled = false;
        }
        if (Input.GetKey(KeyCode.X))
        {
            mop.GetComponent<SpriteRenderer>().enabled = false;
            sponge.GetComponent<SpriteRenderer>().enabled = true;
            mop.GetComponent<CircleCollider2D>().enabled = false;
            sponge.GetComponent<CapsuleCollider2D>().enabled = true;
            bag.GetComponent<SpriteRenderer>().enabled = false;
            bag.GetComponent<CapsuleCollider2D>().enabled = false;
        }
        if (Input.GetKey(KeyCode.C))
        {
            mop.GetComponent<SpriteRenderer>().enabled = true;
            sponge.GetComponent<SpriteRenderer>().enabled = false;
            mop.GetComponent<CircleCollider2D>().enabled = true;
            sponge.GetComponent<CapsuleCollider2D>().enabled = false;
            bag.GetComponent<SpriteRenderer>().enabled = false;
            bag.GetComponent<CapsuleCollider2D>().enabled = false;
        }
        if (Input.GetKey(KeyCode.V))
        {
            mop.GetComponent<SpriteRenderer>().enabled = false;
            sponge.GetComponent<SpriteRenderer>().enabled = false;
            mop.GetComponent<CircleCollider2D>().enabled = false;
            sponge.GetComponent<CapsuleCollider2D>().enabled = false;
            bag.GetComponent<SpriteRenderer>().enabled = true;
            bag.GetComponent<CapsuleCollider2D>().enabled = true;
        }
    }
}
