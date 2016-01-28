using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour 
{
	private float currentOffset = 0;
	public float speed = .1f;

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
