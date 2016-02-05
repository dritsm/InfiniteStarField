﻿using UnityEngine;
using System.Collections;

public class AsteroidSpawn : MonoBehaviour 
{

	public float speed = 5f;
	float time = 0;

	public GameObject asteroid;

	private static float WAIT_TIME = .55f;
	private Transform AsteroidSpawnLocation;

	GameObject asteroidClone;

	// Use this for initialization
	void Start () 
	{
		AsteroidSpawnLocation = transform.parent;
	}
	
	// Update is called once per frame
	void Update ()
	{

		time += Time.deltaTime;

		if (time > WAIT_TIME) 
		{
			asteroidClone =	Instantiate (asteroid, transform.position, transform.rotation) as GameObject;
			time = 0;
		}

	}
}