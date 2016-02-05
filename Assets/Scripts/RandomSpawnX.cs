using UnityEngine;
using System.Collections;

public class RandomSpawnX : MonoBehaviour {

	//private float speed = 3f;
	float scaleX = 0;
	float scaleY = 0;

	// Use this for initialization
	void Start () 
	{
		Vector3 position = new Vector3 (Random.Range (-12.3f, 12.4f), 10, 0);
		transform.position = position;

		//transform.Rotate (0, 0, Random.Range (0f, 360.0f));


		//transform.rotation =;
		scaleX = Random.Range(.8f, 2.0f);
		scaleY = scaleX;
		Vector3 scale = new Vector3 (scaleX, scaleY, 0);
		transform.localScale = scale;


	}
	
	// Update is called once per frame
	void Update () {
		
	
	}
}

