using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
this func is used to check if all windows are cleaned
*/
public class all_clean : MonoBehaviour
{
    Transform parentTransform;
    int childCount;
    public bool all_cleaned;
    bool allClean;

    [SerializeField]
    bool andOperator;
    void Start()
    {
        parentTransform = GetComponent<Transform>();
        childCount = parentTransform.childCount;
        bool[] window_clean_status = new bool[childCount];
    }

    // Update is called once per frame
    void Update()
    {
        if (andOperator)
        {
            allClean = true;
        }
        else
        {
            allClean = false;
        }
        /*
            this part of code checks every window under the window manager if it dirty or not and calculate allClean;

        */
        for (int i = 0; i < childCount; i++)
        {
            Transform childTransform = parentTransform.GetChild(i);
            cleaning_status status = childTransform.GetComponent<cleaning_status>();

            // Check if this child is dirty
            if (andOperator)
            {
                if (status.dirty)
                {
                    allClean = false;
                    break;
                }
            }
            else
            {
                if (!status.dirty)
                {
                    allClean = true;
                    break;
                }
            }
        }

        all_cleaned = allClean;
    }
}
