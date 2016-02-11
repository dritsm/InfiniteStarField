using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LifeManager : MonoBehaviour {
	public int startingLives;
	private int lifeCounter;

	private bool gameOver = false;

	private Text theText;


	// Use this for initialization
	void Start () {
		theText = GetComponent<Text> ();

		lifeCounter = startingLives;
	
	}
	
	// Update is called once per frame
	void Update () {
		theText.text = "x " + lifeCounter;
	
	}

	public void takeLife(){
		if (lifeCounter > 0 &&!gameOver){
			lifeCounter--;
		}
	}
}
