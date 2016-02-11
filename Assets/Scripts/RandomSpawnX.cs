using UnityEngine;
using System.Collections;

public class RandomSpawnX : MonoBehaviour {
	//For Random Scale
	float scaleX = 0;
	float scaleY = 0;

	//For Random Spin Direction and speed
	float zSpin = Random.Range(-5, 5);



	// Use this for initialization
	void Start () 
	{
		//Random Spawn Position along x axis
		Vector3 position = new Vector3 (Random.Range (-12.3f, 12.4f), 10, 0);
		transform.position = position;

		//Random Scale between range
		scaleX = Random.Range(.8f, 2.0f);
		scaleY = scaleX;
		Vector3 scale = new Vector3 (scaleX, scaleY, 0);
		transform.localScale = scale;


	}
	
	// Update is called once per frame
	void Update () {

		//Spin Random Direction
		transform.Rotate (0, 0, zSpin);


	
	}
}

