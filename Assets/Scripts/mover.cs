using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    * This script is used to control the player
*/
public class mover : MonoBehaviour
{

    [SerializeField]
    GameObject cables;

    [SerializeField]
    Vector3 playerPosOnBuilding;

    [SerializeField]
    GameObject drop_player;

    [SerializeField]
    public float speed = 3f;

    [SerializeField]
    float steps_sound_speed = 1f;
    public bool faceRight = true;
    public GameObject hat;
    public float moveX;
    public float moveY;
    public bool onBuilding = false;
    GameObject cable1;
    GameObject cable2;
    float cable1_freezeY = 0.2f;
    float cable2_freezeY = 0.2f;

    [SerializeField]
    GameObject footStepsSound;

    [SerializeField]
    GameObject buildingSoud;
    private AudioSource steps_sound;
    private AudioSource building_sound;
    private float curr_speed;

    /*
        * This function is called when the game starts
        * It is used to initialize the variables
    */
    void Start()
    {
        steps_sound = footStepsSound.GetComponent<AudioSource>();
        building_sound = buildingSoud.GetComponent<AudioSource>();
        cable1 = cables.transform.Find("cable1").gameObject;
        cable2 = cables.transform.Find("cable2").gameObject;
    }

    /*
         * This function is called once per frame
         * It is used to check if the player is on the building
         * If the player is on the building, the player will move on the building
         * If the player is not on the building, the player will move on the ground
    */
    void Update()
    {
      
        steps_sound.pitch = steps_sound_speed;
        if (!onBuilding)
        {
            PlayerMover();
        }
        else
        {
            moveOnBuilding();
        }
    }

    /*
        * This function is called when the player enters the drop zone
        * It resets the player's position and the cable's position
        * It also disables the collider of the drop zone
    */
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("triggered "+other.tag);
        if (other.tag == "cable")
        {
            gameObject.GetComponent<Animator>().enabled = false;
            hat.GetComponent<SpriteRenderer>().enabled = true;
            onBuilding = true;
            cables.GetComponent<player_follower>().following = true;
            transform.position = playerPosOnBuilding;
            drop_player.GetComponent<CircleCollider2D>().enabled = true;
            GameObject.Find("rightwall").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("leftwall").GetComponent<BoxCollider2D>().enabled = true;

        }
    }

    /*
        * This function is used to flip the player
    */
    void FlipPlayer()
    {
        faceRight = !faceRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    /*
        * This function is used to move the player on the ground
    */
    void PlayerMover()
    {
      
        curr_speed = speed;
        building_sound.Stop();
        moveX = Input.GetAxis("Horizontal");

        if (moveX != 0f)
        {
            /*
                 * This function is used to play the footsteps sound
            */
            if (!steps_sound.isPlaying)
            {
                steps_sound.Play();
            }
        }
        else
        {
            // Stop the footsteps sound.
            steps_sound.Stop();
        }

        if (moveX < 0.0f && faceRight == false)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && faceRight)
        {
            FlipPlayer();
        }
        if (moveX != 0f)
        {
            gameObject.GetComponent<Animator>().enabled = true;
        }
        else
        {
            gameObject.GetComponent<Animator>().enabled = false;
        }
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(
            moveX * curr_speed,
            gameObject.GetComponent<Rigidbody2D>().velocity.y
        );
    }

    /*
        * This function is used to move the player on the building, vertical movement enabled.
    */
    void moveOnBuilding()
    {
        curr_speed = speed / 2;
        steps_sound.Stop();
        if (!building_sound.isPlaying)
        {
            building_sound.Play();
        }
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        if (moveX < 0.0f && faceRight == false)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && faceRight)
        {
            FlipPlayer();
        }
        if (moveY != 0)
        {
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

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(
            moveX * curr_speed,
            moveY * curr_speed
        );
    }
}
