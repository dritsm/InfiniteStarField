//Tells the canvas to update the score

using UnityEngine;
using System.Collections;

public class ScoreTracker : MonoBehaviour 
{
	public UIScript uiCanvas;

	//On contact with gameObject, do this function once
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Respawn") 
		{
			uiCanvas.IncrementShots ();
		}
	}
}
