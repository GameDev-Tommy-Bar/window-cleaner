using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/*
    This script is used to control the tutorial and change/activate game parts.
*/

public class tutorial : MonoBehaviour
{
    public GameObject cables;
    public GameObject txt;
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
    private string open_text = "Hey new player\nWelcome to your new job\nas window cleaner!";
    private string first_hint = "Hurry up!\nClimb the building\nand start cleaning!!";
    private string change_items = "Your tools are:\nMop, Sponge, and Money bag.\nChange them with 'Z', 'X', 'C', 'V' keys";
    private string patience_bar = "See the patience bar\nat the top left.\nWhen the building is dirty\nthe boss is getting mad!";
    private string drop_cable = "See this blue attach point?\nIt's next to the door.\nThis is how you can\ndrop down from the cables.";

    private void Start()
    {
        tutorial_text.text = open_text; // First text that should be displayed
        StartCoroutine(FirstHintChange());
    }

    private void Update()
    {
        if (cable_touch)
        {
            tutorial_text.text = change_items;
            cables_arrow.GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(ChangeToBarHint());
            cable_touch = false;
        }
        if (drop_cable_touch)
        {
            drop_cable_touch = false;
            cable_drop_arrow.GetComponent<SpriteRenderer>().enabled = false;
            tutorial_text.text = "GOOD LUCK!";
            StartCoroutine(EmptyText());
        }
    }

    private IEnumerator FirstHintChange()
    {
        yield return new WaitForSeconds(4f);
        cables.SetActive(true);
        cables_arrow.GetComponent<SpriteRenderer>().enabled = true;
        tutorial_text.text = first_hint;
    }

    private IEnumerator ChangeToBarHint()
    {
        yield return new WaitForSeconds(10f);
        tutorial_text.text = patience_bar;
        health_bar.GetComponent<p_bar>().increaseFull();
        health_bar.SetActive(true);
        bar_arrow.GetComponent<SpriteRenderer>().enabled = true;
        StartCoroutine(ChangeToDropCableHint());
    }

    private IEnumerator ChangeToDropCableHint()
    {
        yield return new WaitForSeconds(8f);
        bar_arrow.GetComponent<SpriteRenderer>().enabled = false;
        cable_drop_arrow.GetComponent<SpriteRenderer>().enabled = true;
        tutorial_text.text = drop_cable;
        cable_drop.SetActive(true);
    }

    private IEnumerator EmptyText()
    {
        yield return new WaitForSeconds(4f);
        background.GetComponent<SpriteRenderer>().enabled = false;
        txt.SetActive(false);
        health_bar.GetComponent<p_bar>().increaseFull();
    }
}
