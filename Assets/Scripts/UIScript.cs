using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIScript : MonoBehaviour {
	public Text ScoreText;
	private int score = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void IncrementShots(){
		ScoreText.text = string.Format("Score: {0}", score += 10);
	}
}
