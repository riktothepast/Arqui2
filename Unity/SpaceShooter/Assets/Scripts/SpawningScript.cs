using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawningScript : MonoBehaviour {
    public int timeToSpawn;
    public List<GameObject> objectsToSpawn;
	// Use this for initialization
	void Start () {
        StartCoroutine(NewEnemy());
	}
	
	// Update is called once per frame
	void Update () {
        //generate a new object!
        
	}

    public IEnumerator NewEnemy()
    {

        yield return new WaitForSeconds(timeToSpawn);
        Instantiate(objectsToSpawn[Random.Range(0, objectsToSpawn.Count)], transform.position + new Vector3(Random.Range(-Screen.width/100, Screen.width/100), 0, 0), transform.rotation);
        if(GameObject.Find("playerShip").GetComponent<MovementScript>().life > 0 &&
		   GameObject.Find("GUI").GetComponent<GUIScript>().timeToWin > 0)
		{
			yield return StartCoroutine(NewEnemy());
		}else
		{
			yield return null;
		}

    }
}
