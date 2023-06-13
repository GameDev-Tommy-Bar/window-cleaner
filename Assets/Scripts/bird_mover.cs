using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_mover : MonoBehaviour
{
    // this script used for adjusting thee bird move
    public float moveSpeed = 3f; // The speed at which the bird moves
    bool flip = false;

    private void Update()
    {
        // Move the bird horizontally
        if (moveSpeed < 0)
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            if (flip == false)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                flip = true;
            }
        }
        if (moveSpeed > 0)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            if (flip == true)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                flip = false;
            }
        }
    }
}
