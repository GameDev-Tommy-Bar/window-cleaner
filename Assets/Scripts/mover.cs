using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    Vector3 pos_up_down;
    Vector3 pos_right_left;
    //[SerializeField] GameObject cable_colliders;
    [SerializeField] GameObject cables;
    [SerializeField] float speed = 3f;
    public bool faceRight = true;
    public GameObject hat;
    public float moveX;
    public float moveY;
    Collider2D t;
    private bool isTouchingGround = true;
    private bool onBuilding = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(!onBuilding){
            PlayerMover();
        }
        else{
            moveOnBuilding();
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
       Debug.Log("triggered" + other.tag);
        if(other.tag == "cable"){
            isTouchingGround = false;
            //transform.position = new Vector3(-2.16f,-2.43f,-0.36f);
            other.transform.parent = transform;
            gameObject.GetComponent<Animator>().enabled = false;
            hat.GetComponent<SpriteRenderer>().enabled = true;
            onBuilding = true;
        }

        

    }
    void OnCollisionEnter2D(Collision2D collision)
{
    // Check if the collision is with an object that should prevent upward movement
    if (collision.gameObject.CompareTag("Roof"))
    {
        Debug.Log("rooooooooof");
        // Set the y-axis velocity to 0 to prevent upward movement
       // gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, 0f);
    }
}

    // void OnTriggerExit2D(Collider2D other)
    // {
    //     // If the player exits an object with the "Roof" tag, allow it to move freely again
    //     if (other.CompareTag("Roof"))
    //     {
    //         Debug.Log("STOP touced");
    //         gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(gameObject.GetComponent<Rigidbody2D>().velocity.x, moveY * speed);
    //     }
    // }

    
    void FlipPlayer()
    {
        faceRight = !faceRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    void PlayerMover()
    {
        moveX = Input.GetAxis("Horizontal");

        if (moveX < 0.0f && faceRight == false)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && faceRight)
        {
            FlipPlayer();
        }
        if(moveX != 0f){
            gameObject.GetComponent<Animator>().enabled = true;
        }
        else{
            gameObject.GetComponent<Animator>().enabled = false;
        }
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(
            moveX * speed,
            gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void moveOnBuilding(){
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

        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(
            moveX * speed,
            moveY * speed);
    
    }

}
