using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_chapter : MonoBehaviour
{
    [SerializeField]
    string chapter_name;

    public void load_level()
    {
        SceneManager.LoadScene(chapter_name);
    }
}
