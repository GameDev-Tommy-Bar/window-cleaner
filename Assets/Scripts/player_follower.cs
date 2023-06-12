using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    * This script is used to control the cables to follow the player position
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
    [SerializeField] GameObject building;
    [SerializeField] GameObject cable1;
    [SerializeField] GameObject cable2;
    [SerializeField]float cable1_freezeY = 0.2f;
    [SerializeField]float cable2_freezeY = 0.2f;
    [SerializeField] GameObject cables;
    [SerializeField] GameObject drop_player;
    [SerializeField] GameObject birdSpawnner;
    [SerializeField] GameObject border;



    void Start() { }
        
    // Update is called once per frame
    void Update()
    {
        if (following )
        {
        if(player.GetComponent<mover>().moveY !=0 ){
             
        
            cable1.transform.position = new Vector3(
                cable1.transform.position.x,
                cable1_freezeY,
                cable1.transform.position.z
            );
            cable2.transform.position = new Vector3(
                cable2.transform.position.x,
                cable2_freezeY,
                cable2.transform.position.z
            );
        
        } 
            follow();
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Player"){
            cables.GetComponent<player_follower>().following = true;
            drop_player.GetComponent<CircleCollider2D>().enabled = true;
            birdSpawnner.SetActive(true);
            border.SetActive(true);

        }
      
    }

    public void follow()
    {
        //if the player tuch this cables then the cables will follow the player position 
        
        playerPos = player.transform.position;
        transform.position = playerPos + cables_offset;
    }
      
}
