using UnityEngine;
using System.Collections;

public class PlatformMovementScript : MonoBehaviour {
    public Vector2 movement;
    public float movementSpeed;

    SpriteRenderer spriteRenderer;
	// Use this for initialization
	void Start () {
        spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector2(transform.position.x + movement.x * movementSpeed * Time.deltaTime, transform.position.y + movement.y * movementSpeed * Time.deltaTime);

        if (Camera.main.WorldToViewportPoint(new Vector3(transform.position.x + spriteRenderer.sprite.bounds.max.x *2, transform.position.y, transform.position.z)).x < 0)
        {
            Vector3 screen = new Vector3(Screen.width, Screen.height, 0);
            Vector3 worldScreen = Camera.main.ScreenToWorldPoint(screen);

            transform.position = new Vector2(worldScreen.x + spriteRenderer.sprite.bounds.max.x, transform.position.y );

        }
    }
}
