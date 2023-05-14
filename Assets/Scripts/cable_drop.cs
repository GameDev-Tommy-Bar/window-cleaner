using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cable_drop : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Vector3 cable_origin_pos;
    [SerializeField] Vector3 player_origin_pos;
    [SerializeField] GameObject player; 
    [SerializeField] GameObject cables;
    [SerializeField] GameObject hat;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            cables.GetComponent<player_follower>().following = false;
            cables.transform.position = cable_origin_pos;
            transform.GetComponent<CircleCollider2D>().enabled = false;
            player.transform.position = player_origin_pos;
            player.GetComponent<mover>().onBuilding = false;
            hat.GetComponent<SpriteRenderer>().enabled = false; 

        }
    }
}
