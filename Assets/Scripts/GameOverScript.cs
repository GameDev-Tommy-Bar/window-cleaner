using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class GameOverScript : MonoBehaviour
{
    public TMP_Text points_text;
    public TMP_Text score_text;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        points_text.text = score + " POINTS";
    }

    public void play_again()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
