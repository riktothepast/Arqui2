using UnityEngine;
using System.Collections;

public class Enemy1Script : MonoBehaviour {
    public GameObject laserEnemy;
    public GameObject particleOnHit;
    public int energy;
    public Vector2 velocity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate( velocity * Time.deltaTime);
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if(screenPosition.y < 0 || energy == 0)
		{
			destroyEnemy();
		}
	}

	public void destroyEnemy()
	{
		Destroy(this.gameObject);
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.CompareTag("Laser"))
		{
			GameObject.Find("Main Camera").GetComponent<ScreenShake>().Shake(1f);
			energy--;
            Instantiate(particleOnHit, transform.position, transform.rotation);
			Destroy(other.gameObject);
		}

	}
}
