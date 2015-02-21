using UnityEngine;
using System.Collections;

public class ScoreCheck : MonoBehaviour {

    public float scorePoints;
    ScoreAddition scoreAdition;
	// Use this for initialization
	void Start () {
        scoreAdition = GameObject.FindGameObjectWithTag("MainCamera").GetComponentInChildren<ScoreAddition>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        Destroy(coll.gameObject);
        scoreAdition.AddToScore(scorePoints);
    }
}
