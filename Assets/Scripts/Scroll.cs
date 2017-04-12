//This script creates an infinitely scrolling background

//Solution created from a mix of many authors

using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour 
{
	private float currentOffset = 0;
	public float speed = .1f;

	//Use this for Initialization
	void Start()
	{
		currentOffset += Time.deltaTime * speed; 
	} //end start

	// Update is called once per frame
	void Update ()
	{
		currentOffset += Time.deltaTime * speed; //scale the speed of the offset to time

		if (currentOffset > 1.0f)
		{
			currentOffset -= 1.0f;
		}   

		GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, currentOffset); //translate texture offset

	}//end update
}//end class
