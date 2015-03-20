using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {
    Vector2 velocity;
	Vector2 screenPosition;
	public float life;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (Input.GetKey(KeyCode.A))
        {
            velocity.x -= Time.deltaTime;
        }
		if (Input.GetKey(KeyCode.D))
        {
            velocity.x += Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            velocity.y += Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity.y -= Time.deltaTime;
        }

        velocity.x *= 0.9f;

        velocity.y *= 0.9f;

		if((screenPosition.x > 0 && velocity.x <= 0) || (screenPosition.x < Screen.width && velocity.x > 0))
	        transform.Translate((Vector2.right * 1) * velocity.x);
        transform.Translate((Vector2.up * 1) * velocity.y);

		if(life <= 0)
		{
			Destroy(this.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.CompareTag("Enemy") || other.CompareTag("EnemyLaser"))
		{
			Destroy(other.gameObject);
			life--;
		}
	}
}
