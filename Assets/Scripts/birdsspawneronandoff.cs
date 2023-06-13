using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdsspawneronandoff : MonoBehaviour
{
    // this script used for enable and disable the bird spawner
    public GameObject birdSpawnner;

    // Start is called before the first frame update
    void Start() { }

    private void OnTriggerEnter2D(Collider2D other)
    {
        birdSpawnner.SetActive(true);
        GameObject.Find("rightwall").GetComponent<BoxCollider2D>().enabled = true;
        GameObject.Find("leftwall").GetComponent<BoxCollider2D>().enabled = true;
    }

    // Update is called once per frame
    void Update() { }
}
