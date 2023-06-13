using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class time_bar : MonoBehaviour
{
    //this script handle the level timer component
    public GameObject end_game;

    [SerializeField]
    public Image uiFill;

    [SerializeField]
    public TMP_Text uiText;
    public int duration;
    public int ramainingDuration;

    void Start()
    {
        Being(duration);
    }

    private void Being(int second)
    {
        ramainingDuration = second;
        StartCoroutine(updateTimer());
    }

    private IEnumerator updateTimer()
    {
        while (ramainingDuration >= 0)
        {
            uiText.text = $"{ramainingDuration / 60:00} : {ramainingDuration % 60:00}";
            uiFill.fillAmount = Mathf.InverseLerp(0, duration, ramainingDuration);
            ramainingDuration--;
            yield return new WaitForSeconds(1f);
        }
        if (ramainingDuration == -1)
        {
            onEnd();
        }
    }

    private void onEnd()
    {
        SceneManager.LoadScene("win");
    }
}
