//Detects if an asteroid passes through this gameobject and decrements the player's life count

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AsteroidDetector : MonoBehaviour 
{
	private LifeManager lifeSystem;

	// Use this for initialization
	void Start () 
	{
		lifeSystem = FindObjectOfType<LifeManager> ();
	}//end start

	//On contact with specific gameobject, perform this once
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Respawn") { lifeSystem.takeLife (); }
	}//end trigger
}//end class
