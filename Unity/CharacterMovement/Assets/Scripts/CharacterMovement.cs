using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
    public float movementSpeed;
    public float jumpSpeed;
    bool grounded;
    Vector2 movement;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        float move = Input.GetAxis("Horizontal");

        if (move < 0) {
            transform.localScale = new Vector3(-1,1,1);       
        }
        if(move > 0){
            transform.localScale = new Vector3(1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.Space) && grounded) {
            rigidbody2D.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);
        }

        rigidbody2D.velocity = new Vector2( move * movementSpeed, rigidbody2D.velocity.y);
	}

    void OnTriggerEnter2D(Collider2D col) {

        if (col.tag.Equals("Platform")) {
            grounded = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {

        if (col.tag.Equals("Platform"))
        {
            grounded = false;
        }
    }
}
