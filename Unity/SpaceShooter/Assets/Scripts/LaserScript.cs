using UnityEngine;
using System.Collections;

public class LaserScript : MonoBehaviour {
    
	public float laserSpeed = 5;
	public float timeToLive;

	// Use this for initialization
	void Start () {
		Invoke("laserDestroy",timeToLive);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate((Vector2.up) * (laserSpeed * Time.deltaTime));
        
	}

	public void laserDestroy()
	{
		Destroy(this.gameObject);
	}
}
