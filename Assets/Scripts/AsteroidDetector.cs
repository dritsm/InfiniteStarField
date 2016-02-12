﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AsteroidDetector : MonoBehaviour {
	private LifeManager lifeSystem;

	// Use this for initialization
	void Start () {
		
		lifeSystem = FindObjectOfType<LifeManager> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other){
	
		if (other.gameObject.tag == "Respawn") {
			
				lifeSystem.takeLife ();
		}
		
	}
}