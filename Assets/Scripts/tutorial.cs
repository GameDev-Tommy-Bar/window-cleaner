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
    public bool is_on = true;
    public GameObject instructions;
    public GameObject cables;
    public GameObject txt;
    public GameObject cable_drop;
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
    private string change_items =
        "Your tools are:\nMop, Sponge, and Money bag.\nChange them with 'Tab' key";
    private string patience_bar =
        "See the patience bar\nat the top left.\nWhen the building is dirty\nthe boss is getting mad!";
    private string drop_cable =
        "See this blue attach point?\nIt's next to the door.\nThis is how you can\ndrop down from the cables.";

    public GameObject cable_border;

    private void Start()
    {
        if (is_on)
        {
            health_bar.SetActive(false);
            cables.SetActive(false);
            cable_drop.SetActive(false);
            background.SetActive(true);
            instructions.SetActive(true);
            tutorial_text.text = open_text; // First text that should be displayed
            StartCoroutine(hint1());
        }
    }

    private void Update()
    {
        if (drop_cable_touch)
        {
            drop_cable_touch = false;
            cable_drop_arrow.GetComponent<SpriteRenderer>().enabled = false;
            tutorial_text.text = "GOOD LUCK!";
            StartCoroutine(EmptyText());
        }
    }

    private IEnumerator hint1()
    {
        yield return new WaitForSeconds(4f);
        cables.SetActive(true);
        cables_arrow.GetComponent<SpriteRenderer>().enabled = true;
        tutorial_text.text = first_hint;
        // cable_border.SetActive(true);

        StartCoroutine(hint2());
    }

    private IEnumerator hint2()
    {
        yield return new WaitForSeconds(6f);
        tutorial_text.text = change_items;
        cables_arrow.GetComponent<SpriteRenderer>().enabled = false;
        StartCoroutine(hint3());
        cable_touch = false;
    }

    private IEnumerator hint3()
    {
        yield return new WaitForSeconds(10f);
        tutorial_text.text = patience_bar;
        health_bar.GetComponent<p_bar>().increaseFull();
        health_bar.SetActive(true);
        bar_arrow.GetComponent<SpriteRenderer>().enabled = true;
        StartCoroutine(hint4());
    }

    private IEnumerator hint4()
    {
        yield return new WaitForSeconds(8f);
        bar_arrow.GetComponent<SpriteRenderer>().enabled = false;
        cable_drop_arrow.GetComponent<SpriteRenderer>().enabled = true;
        tutorial_text.text = drop_cable;
        cable_drop.SetActive(true);
        //drop_cable_touch = false;
        cable_drop_arrow.GetComponent<SpriteRenderer>().enabled = false;
        StartCoroutine(goodluck());
    }

    private IEnumerator EmptyText()
    {
        yield return new WaitForSeconds(8f);
        background.GetComponent<SpriteRenderer>().enabled = false;
        txt.SetActive(false);
        health_bar.GetComponent<p_bar>().increaseFull();
    }

    private IEnumerator goodluck()
    {
        yield return new WaitForSeconds(6);
        tutorial_text.text = "GOOD LUCK!\n survive the day!";
        StartCoroutine(EmptyText());
    }
}
