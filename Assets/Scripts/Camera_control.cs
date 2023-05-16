using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    * This script is used to control the camera to follow the player
*/
public class Camera_control : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    [Range(1, 10)]
    public float SmoothFactor;

    private void FixedUpdate()
    {
        Follow();
    }

    // This function is used to follow the player
    void Follow()
    {
        Vector3 targetPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(
            transform.position,
            targetPosition,
            SmoothFactor * Time.fixedDeltaTime
        );
        transform.position = targetPosition;
    }
}
