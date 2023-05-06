using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;


public class cleaning_status : MonoBehaviour
{
    [SerializeField] GameObject mud;
    [SerializeField] GameObject bubbles;
    [SerializeField] GameObject coin;
    public TMP_Text scoreText;
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
            Debug.Log("hi");
            mud.GetComponent<SpriteRenderer>().enabled = false;
            bubbles.GetComponent<SpriteRenderer>().enabled = true;
            is_mud = false;
            is_bubbled = true;
        }
        if(other.tag == "mop" && is_bubbled){
            bubbles.GetComponent<SpriteRenderer>().enabled = false;
            is_mud = false;
            is_bubbled = false;
            coin.GetComponent<SpriteRenderer>().enabled = true;
        }
        if(other.tag == "bag" && coin.GetComponent<SpriteRenderer>().enabled == true ) {
            coin.GetComponent<SpriteRenderer>().enabled = false;
            int score = Int32.Parse(scoreText.text);
            score += 1;
            scoreText.text = score.ToString();
    }

}
}
