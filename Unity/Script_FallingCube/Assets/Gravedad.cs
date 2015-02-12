using UnityEngine;
using System.Collections;

public class Gravedad : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x, transform.position.y - 10f *Time.deltaTime, transform.position.z);
	}
}
