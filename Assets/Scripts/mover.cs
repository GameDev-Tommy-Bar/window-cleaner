using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    Vector3 pos_up_down;
    Vector3 pos_right_left;
    [SerializeField] float speed = 3f;
    public bool faceRight = true;
    public float moveX;

    // Start is called before the first frame update
    void Start()
    {
            pos_up_down = new Vector3(0,0.1f,0);
            pos_right_left = new Vector3(0.1f,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Transform>().position += pos_up_down*speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Transform>().position -= pos_up_down*speed;

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Transform>().position += pos_right_left*speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
           GetComponent<Transform>().position -= pos_right_left*speed;
        }
        if (moveX < 0.0f && faceRight == false)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && faceRight)
        {
            FlipPlayer();
        }
    }

    void FlipPlayer()
    {
        faceRight = !faceRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
