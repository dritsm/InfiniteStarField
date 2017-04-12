//This script controls the degree of rotation of an object
//based on the horizontal axis and it will then transition back
//to default positon smoothly

//Created by KODY BUSS

using UnityEngine;
using System.Collections;

public class RotationScript : MonoBehaviour 
{
	private float x;
	private float _rotationZ = 0f;
	private float _rotationY = 0f;

	public float angleSensitivityHor = 9.0f;

	// Use this for initialization
	void Start () 
	{
		Rigidbody body = GetComponent<Rigidbody> ();

		if (body != null)
			body.freezeRotation = true;
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		x = Input.GetAxis ("Horizontal");
 
		_rotationZ = x * angleSensitivityHor;// use -= if I want to maintain angle each frame
		transform.Rotate (0f, 0f , _rotationZ);// rotate object

		_rotationY = transform.localEulerAngles.y;//scalable y reset positon based off current position
		transform.localEulerAngles = new Vector3 (0f, _rotationY , _rotationZ * -1); //resets position

	}
}
