using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    * This script is used to control the camera to follow the player
*/
public class player_follower : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject player;

    [SerializeField]
    Vector3 cables_offset;
    Vector3 playerPos;
    public bool following = false;

    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (following)
        {
            follow();
        }
    }

    public void follow()
    {
        playerPos = player.transform.position;
        transform.position = playerPos + cables_offset;
    }
}
