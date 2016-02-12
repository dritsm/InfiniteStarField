﻿//This script creates an infinitely scrolling background
//on a given quad

//Solution created from a mix of many authors

using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour 
{
	private float currentOffset = 0;
	public float speed = .1f;

	void Start() {
		currentOffset += Time.deltaTime * speed; 
	}

	// Update is called once per frame
	void Update ()
	{
		currentOffset += Time.deltaTime * speed;
		if (currentOffset > 1.0f)
		{
			currentOffset -= 1.0f;
		}   

		GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, currentOffset); 
	}
}
