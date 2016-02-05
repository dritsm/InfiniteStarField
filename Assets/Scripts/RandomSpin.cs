using UnityEngine;
using System.Collections;

public class RandomSpin : MonoBehaviour {

	public float speed = 2f;
	float zSpin = Random.Range(-5, 5);


	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (0, 0, zSpin);
	}
}
