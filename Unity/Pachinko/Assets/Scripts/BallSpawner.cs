using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {
    public GameObject ball;
    Vector3 mousePosition;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        //revisa si se presiona el click izquierdo del mouse.
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = camera.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0;

            Instantiate(ball, mousePosition, transform.rotation);
        }
	}
}
