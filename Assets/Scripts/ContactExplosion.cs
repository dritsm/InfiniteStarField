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
		Destroy (gameObject, 6);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			
			explosionClone = Instantiate (explosion, transform.position, transform.rotation) as GameObject;

			Destroy (explosionClone, 1f);
			Destroy (gameObject);
		}
	}
}
	