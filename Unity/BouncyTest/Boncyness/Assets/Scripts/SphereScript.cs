using UnityEngine;
using System.Collections;

public class SphereScript : MonoBehaviour {

    // this value changes how much the ball will bounce
    public float bouncyFactor;
    // how much force should we give to the sphere?
    public Vector3 initialForce;
	
    // Use this for initialization
	void Start () {

        // get the GO phyciscs material and change its bouncyFactor.
        GetComponent<SphereCollider>().material.bounciness = bouncyFactor;

        //lets add some force and a force mode
        GetComponent<Rigidbody>().AddForce(initialForce, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
