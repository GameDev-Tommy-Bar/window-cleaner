using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class cleaning_status : MonoBehaviour
{
    [SerializeField] GameObject patience_bar;
    [SerializeField]
    GameObject mud;

    [SerializeField]
    GameObject bubbles;

    [SerializeField]
    GameObject coin;
    GameObject windows_manager;

    public TMP_Text scoreText;
    bool is_mud = true;
    bool is_bubbled = false;
    public bool dirty = true;

    // Start is called before the first frame update
    void Start()
    {
        windows_manager = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(dirty);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "sponge" && is_mud)
        {
            mud.GetComponent<SpriteRenderer>().enabled = false;
            bubbles.GetComponent<SpriteRenderer>().enabled = true;
            is_mud = false;
            is_bubbled = true;
            dirty = true;
        }
        if (other.tag == "mop" && is_bubbled)
        {
            bubbles.GetComponent<SpriteRenderer>().enabled = false;
            is_mud = false;
            is_bubbled = false;
            dirty = false;
            coin.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (other.tag == "bag" && coin.GetComponent<SpriteRenderer>().enabled == true)
        {
            coin.GetComponent<SpriteRenderer>().enabled = false;
            int score = Int32.Parse(scoreText.text);
            score += 1;
            patience_bar.GetComponent<p_bar>().increaseBar(10);
            scoreText.text = score.ToString();
            if (!dirty)
            {
                StartCoroutine(MakeDirtyAgain());
            }
        }
    }

    IEnumerator MakeDirtyAgain()
    {
        float time = windows_manager.GetComponent<timer>().get_time();
        yield return new WaitForSeconds(time);
        mud.GetComponent<SpriteRenderer>().enabled = true;
        is_mud = true;
        is_bubbled = false;
        dirty = true;
    }
}
