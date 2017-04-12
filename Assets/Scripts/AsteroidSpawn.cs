using UnityEngine;
using System.Collections;

public class AsteroidSpawn : MonoBehaviour 
{
	private static float waitTime = .77f;
	private float time = 0;

	private Transform AsteroidSpawnLocation;
	private GameObject asteroidClone;

	public GameObject asteroid;

	// Use this for initialization
	void Start () 
	{
		AsteroidSpawnLocation = transform.parent;
	}//end start
	
	// Update is called once per frame
	void Update ()
	{
		time += Time.deltaTime;//increment time with real time

		if (time > waitTime) 
		{
			//Create new gameObject from prehab
			asteroidClone =	Instantiate (asteroid, transform.position, transform.rotation) as GameObject;
			time = 0;
		}
	}//end update
}//end class
