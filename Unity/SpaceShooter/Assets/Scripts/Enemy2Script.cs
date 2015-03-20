using UnityEngine;
using System.Collections;

public class Enemy2Script : MonoBehaviour
{
    public GameObject laserEnemy;
	public GameObject particleOnHit;
    public int energy;
    public Vector3 velocity;
    public float verticalMovement;
    float time;
    public int timeToShoot;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity * Time.deltaTime);
        transform.Translate(new Vector3(verticalMovement * Mathf.Cos(time), 0, 0));
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        time += Time.deltaTime;



        if (screenPosition.y < 0 || energy == 0)
        {
            destroyEnemy();
        }
    }

    public void destroyEnemy()
    {
        Destroy(this.gameObject);
    }

    public IEnumerator Shoot()
    {
        yield return new WaitForSeconds(timeToShoot);
        Instantiate(laserEnemy, transform.position + new Vector3(0, -1, 0), transform.rotation);
        StartCoroutine(Shoot());
    }

	void OnTriggerEnter2D(Collider2D other) {
		if(other.CompareTag("Laser"))
		{
			GameObject.Find("Main Camera").GetComponent<ScreenShake>().Shake(1f);
			Instantiate(particleOnHit, transform.position, transform.rotation);
			energy--;
			Destroy(other.gameObject);
		}
	}
}
