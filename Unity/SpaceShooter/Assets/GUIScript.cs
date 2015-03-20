using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {

	public float timeToWin;

	MovementScript player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("playerShip").GetComponent<MovementScript>();
	}
	
	// Update is called once per frame
	void Update () {
		if(player.life > 0 && timeToWin > 0)
		{
			timeToWin -= Time.deltaTime;
		}
	}

	void OnGUI()
	{
		string minutes = Mathf.Floor(timeToWin / 60).ToString("00");
		string seconds = (timeToWin % 60).ToString("00");
		GUI.Label(new Rect(10, 10, 100, 20),"Time: "+minutes+":"+seconds);

		if(player.life > 0 && timeToWin <= 0)
		{
			GUI.Label(new Rect(Screen.width / 2, Screen.height / 2  - 60f, 90f , 60f),"You win! :D");
			if(GUI.Button(new Rect(Screen.width / 2, Screen.height / 2  + 30f, 90f , 60f),"Play Again!"))
			{
				Application.LoadLevel("GameScene");
			}

		}

		if(player.life <= 0 && timeToWin > 0)
		{
			GUI.Label(new Rect(Screen.width / 2, Screen.height / 2  - 60f, 90f , 60f),"You lost! :(");
			if(GUI.Button(new Rect(Screen.width / 2, Screen.height / 2  + 30f, 90f , 60f),"Play Again!"))
			{
				Application.LoadLevel("GameScene");
			}
		}
	}
}
