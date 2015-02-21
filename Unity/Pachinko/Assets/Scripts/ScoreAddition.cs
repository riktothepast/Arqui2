using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreAddition : MonoBehaviour {

    float currentScore;
    Text text;

	// Use this for initialization
	void Start () {
        text = GetComponentInChildren<Text>();
        text.text = "Score : 0";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AddToScore(float value)
    {
        currentScore += value;
        text.text = "Score : "+currentScore;
    }
}
