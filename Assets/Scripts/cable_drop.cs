using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    * This script is attached to the cable drop zone
    * It is used to reset the player's position and the cable's position
    * It is also used to disable the collider of the drop zone
*/
public class cable_drop : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject birdSpawnner;
    [SerializeField]
    Vector3 cable_origin_pos;

    [SerializeField]
    Vector3 player_origin_pos;

    [SerializeField]
    GameObject player;

    [SerializeField]
    GameObject cables;

    [SerializeField]
    GameObject hat;

    [SerializeField]
    GameObject border;

    [SerializeField]
    GameObject tutorial_manage;

    void Start() { }

    // Update is called once per frame
    void Update() { }
    /*
        * This function is called when the player enters the drop zone
        * It resets the player's position and the cable's position
        * It also disable the house limits colliders
        * It also disables the collider of the drop zone
        * the if(first) part mean its first time - using tutorial.
    */
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && player.GetComponent<mover>().onBuilding )
        {
            birdSpawnner.SetActive(false);
            cables.GetComponent<player_follower>().following = false;
            cables.transform.position = cable_origin_pos;
            transform.GetComponent<CircleCollider2D>().enabled = false;
            player.transform.position = player_origin_pos;
            player.GetComponent<mover>().onBuilding = false;
            hat.GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("rightwall").GetComponent<BoxCollider2D>().enabled = false;
            GameObject.Find("leftwall").GetComponent<BoxCollider2D>().enabled = false;
            
        }
    }
}
