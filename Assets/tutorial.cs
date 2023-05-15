using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;



public class tutorial : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cables;
    public GameObject cable_drop;
    public GameObject barObject;
    public GameObject health_bar;
    public GameObject background;
    public GameObject cable_drop_arrow;
    public GameObject cables_arrow;
    public GameObject bar_arrow;
    public TMP_Text tutorial_text;
    public bool drop_cable_touch = false;
    public bool cable_touch = false;
    public bool move_start = false;
    string open_text = "hey new player\nwelcome to your new job\nas window cleaner!";
    string first_hint = "hurry up!\nclimb the building\nand start cleaning!!";
    string change_items = "your tools are:\nMop, Sponge and Money bag.\nchange them with 'Z 'X 'C 'V\nkeys";
    string patienc_bar = "see the patience bar\nat the top left.\nwhen building is dirty\nthe boss is getting mad!";
    string drop_cable = "see this blue attach point?\nits next to the door\nthis is how you can\nget down from the cables";
    void Start()
    {
        tutorial_text.text = open_text;
        StartCoroutine(first_hint_change());    
    }

    // Update is called once per frame
    void Update()
    {

        if(cable_touch){
            tutorial_text.text = change_items;
            //tutorial_text.transform.position = new Vector3(344.6f,-215.19f,1.84f);
            cables_arrow.GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(change_to_bar_hint());
            
        }
        if(drop_cable_touch){
            drop_cable_touch = false;
            cable_drop_arrow.GetComponent<SpriteRenderer>().enabled = false;
            tutorial_text.text = "GOOD LUCK!";
            StartCoroutine(empty_text());        }
        
        
    }
    IEnumerator first_hint_change(){
        yield return new WaitForSeconds(4f);
        cables.SetActive(true);
        cables_arrow.GetComponent<SpriteRenderer>().enabled = true;
        tutorial_text.text = first_hint;

    }

    IEnumerator change_to_bar_hint(){
        yield return new WaitForSeconds(10f);
        tutorial_text.text = patienc_bar;
        health_bar.GetComponent<p_bar>().increaseFull();
        health_bar.SetActive(true);
        bar_arrow.GetComponent<SpriteRenderer>().enabled = true;
        StartCoroutine(change_to_drop_cable_hint());
    }
    IEnumerator change_to_drop_cable_hint(){
        yield return new WaitForSeconds(8f);
        //cable_drop.GetComponent<CircleCollider2D>().enabled = true;
        bar_arrow.GetComponent<SpriteRenderer>().enabled = false;
        cable_drop_arrow.GetComponent<SpriteRenderer>().enabled = true;
        tutorial_text.text = drop_cable;
        cable_drop.SetActive(true);
    }
    IEnumerator empty_text(){
        yield return new WaitForSeconds(4f);
        background.GetComponent<SpriteRenderer>().enabled = false;
        tutorial_text.text = " ";
        health_bar.GetComponent<p_bar>().increaseFull();
    }
}
