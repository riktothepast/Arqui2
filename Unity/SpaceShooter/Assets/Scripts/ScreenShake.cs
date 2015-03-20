using UnityEngine;
using System.Collections;

public class ScreenShake : MonoBehaviour {

	public float ShakeAmount = 0.25f;
	public float DecreaseFactor = 1.0f;
	
    private Camera cam;
	private Vector3 cameraPos;
	private float shake = 0.0f;
	
	void Start()
	{
		cam = GetComponent<Camera>();
	}

	void Update() 
	{
		if (this.shake > 0.0f) {
			var shakeArea = Random.insideUnitSphere * ShakeAmount * shake;
			cam.transform.localPosition = new Vector3(shakeArea.x, shakeArea.y, cam.transform.position.z);
			shake -= Time.deltaTime * DecreaseFactor;
			
			if (shake <= 0.0f) {
				shake = 0.0f;
				cam.transform.localPosition = this.cameraPos;
			}
		}
	}

	public void Shake(float amount) 
	{
		if (shake <= 0.0f) {
			cameraPos = cam.transform.position;
		}
		shake = amount;
	}
}
