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
    int change = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            change++;
            if (change % 4 == 0)
            {
                mop.SetActive(false);
                sponge.SetActive(false);
                bag.SetActive(false);
            }

            if (change % 4 == 1)
            {
                mop.SetActive(false);
                sponge.SetActive(true);
                bag.SetActive(false);
            }
            if (change % 4 == 2)
            {
                mop.SetActive(true);
                sponge.SetActive(false);
                bag.SetActive(false);
            }
            if (change % 4 == 3)
            {
                mop.SetActive(false);
                sponge.SetActive(false);
                bag.SetActive(true);
            }
        }
    }
}
