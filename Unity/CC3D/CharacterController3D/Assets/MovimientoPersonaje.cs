using UnityEngine;
using System.Collections;

public class MovimientoPersonaje : MonoBehaviour {

    Vector3 velocity;
    public float gravity;
    public float jumpImpulse;
    public float movementSpeed;
    CharacterController characterController;

	// Use this for initialization
	void Start () {
        characterController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        velocity.y += gravity * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            velocity.y = jumpImpulse;
        }

        velocity.x = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        velocity.z = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        characterController.Move(velocity);
	}
}
