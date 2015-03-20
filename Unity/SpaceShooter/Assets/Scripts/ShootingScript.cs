using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour {

    public GameObject laserBlue;
    float timePassed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            Shoot();
        }


    }

    public void Shoot()
    {
        //some cadence time!
        if (Time.time - timePassed > 0.2f)
        {
            Instantiate(laserBlue, transform.position + new Vector3(0, 1, 0), transform.rotation);
            timePassed = Time.time;
        }
    }
}
