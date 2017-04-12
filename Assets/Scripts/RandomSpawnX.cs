//Instantiates an object along an the x axis with a clamped range, random spin, speed, and size

using UnityEngine;
using System.Collections;

public class RandomSpawnX : MonoBehaviour 
{
	//For Random Scale
	private float scaleX = 0;
	private float scaleY = 0;

	//For Random Spin Direction and speed
	private float zSpin;

	// Use this for initialization
	void Start () 
	{
		//Random Spawn Position along x axis
		Vector3 position = new Vector3 (Random.Range (-12.3f, 12.4f), 10, 0);
		transform.position = position;

		//Set Random Scale between range
		scaleX = Random.Range(.8f, 2.0f);
		scaleY = scaleX; //scale evenly along x and y axis

		//Implement scale
		Vector3 scale = new Vector3 (scaleX, scaleY, 0);
		transform.localScale = scale;

		//Set range for z spin
		zSpin = Random.Range (-5, 5);

	}
	
	// Update is called once per frame
	void Update () 
	{
		//Spin Random Direction
		transform.Rotate (0, 0, zSpin);
	}
}

