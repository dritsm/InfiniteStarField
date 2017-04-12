//Generates an explosion on contact then explosion fades away on Destroy

using UnityEngine;
using System.Collections;

public class ContactExplosion : MonoBehaviour 
{
	
	public GameObject explosion;
	GameObject explosionClone;

	public float fadeSpeed = 0f;
	public float fadeTime = .2f;

	// Use this for initialization
	void Start () 
	{
		Destroy (gameObject, 6); //if not hit destroy off screen
	}

	//trigger once on contact with gameobject tag
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			//create an explosion where the asteroid is destroyed
			explosionClone = Instantiate (explosion, transform.position, transform.rotation) as GameObject;

			Destroy (gameObject);//destroy on contract
		}
	}
}
	