//Controls the player movement
//Borrowed from Professor Blayne Mayfield

using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour 
{
	public float speed = 0.1f;
	private float x, y;

	// Use this for initialization
	void Start () 
	{
		Time.timeScale = 1; //Begin at full gameplay speed
	}
	
	// Update is called once per frame
	void Update () 
	{
		x = Input.GetAxis ("Horizontal");
		y = Input.GetAxis ("Vertical");

		//Scale horizontal and vertical axis to max speed
		transform.position = transform.position +
			new Vector3 (x * speed, y * speed, 0);
	}
}
