using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird_destroy : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "kill_bird"){
            Destroy(this.gameObject);
            Debug.Log("destroyed");
        }
        if(other.gameObject.tag == "player"){
            Debug.Log("player");
            Destroy(this.gameObject);
            StartCoroutine(speed_change());
    
        }   
    }
    private IEnumerator speed_change(){
        float speed = player.GetComponent<mover>().speed;
        player.GetComponent<mover>().speed = speed /2;
        yield return new WaitForSeconds(3);
        player.GetComponent<mover>().speed = speed;
    }
}
