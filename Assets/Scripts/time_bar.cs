using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class time_bar : MonoBehaviour
{
    // Start is called before the first frame update
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

    // Update is called once per frame
    void Update() { }

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
        onEnd();
    }

    private void onEnd() { 
        
    }
}
