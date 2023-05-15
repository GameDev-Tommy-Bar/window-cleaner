using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class all_clean : MonoBehaviour
{
    Transform parentTransform;
    int childCount;
    public bool all_cleaned;
    bool allClean;

    [Tooltip("if true, when one window is dirty the windows count as dirty")]
    [SerializeField]
    bool andOperator;

    //List<bool> boolList; = new List<bool>(10); // Set capacity to 10
    // Start is called before the first frame update
    void Start()
    {
        parentTransform = GetComponent<Transform>();
        childCount = parentTransform.childCount;
        bool[] window_clean_status = new bool[childCount];
    }

    // Update is called once per frame
    void Update()
    {
        //parentTransform = GetComponent<Transform>();

        // Get the number of child objects
        //childCount = parentTransform.childCount;

        // Loop through all child objects and check if they are clean
        if (andOperator)
        {
            allClean = true;
        }
        else
        {
            allClean = false;
        }
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
