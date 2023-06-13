using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_hint : MonoBehaviour
{
    // this script is used for remove bird hint in level 3 after 10 seconds
    // Start is called before the first frame update
    float time = 10f;

    void Start()
    {
        StartCoroutine(remove_hint());
    }

    // Update is called once per frame
    void Update() { }

    private IEnumerator remove_hint()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
