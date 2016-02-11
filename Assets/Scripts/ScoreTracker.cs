using UnityEngine;
using System.Collections;

public class ScoreTracker : MonoBehaviour {

	public UIScript uiCanvas;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Respawn") 
		{
			uiCanvas.IncrementShots ();
		}
	}
}
