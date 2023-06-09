using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    // this script used for set the position of the bird spwner
    public GameObject bird;

    [SerializeField]
    float min_time = 0;

    [SerializeField]
    float max_time = 0;
    float time;

    [SerializeField]
    float min_speed = 0;

    [SerializeField]
    float max_speed = 0;
    float speed;

    [SerializeField]
    float min_y = 0;

    [SerializeField]
    float max_y = 0;
    float y;
    Vector3 position;
    public bool isOn = true;

    void Start()
    {
        if (isOn)
        {
            StartCoroutine(bird_spawn());
        }
    }

    // Update is called once per frame
    void Update() { }

    private IEnumerator bird_spawn()
    {
        while (true)
        {
            speed = Random.Range(min_speed, max_speed);
            time = Random.Range(min_time, max_time);
            y = Random.Range(min_y, max_y);
            position = new Vector3(transform.position.x, y, -2.5f);
            yield return new WaitForSeconds(time);
            Instantiate(bird, position, transform.rotation);
            bird.GetComponent<bird_mover>().moveSpeed = speed;
        }
    }
}
