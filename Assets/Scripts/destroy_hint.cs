using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_hint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(remove_hint());
    }

    // Update is called once per frame
    void Update() { }

    private IEnumerator remove_hint()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
    }
}
