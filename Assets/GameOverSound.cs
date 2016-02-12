using UnityEngine;
using System.Collections;

public class GameOverSound : MonoBehaviour {

	public AudioSource losingSound;

	// Use this for initialization
	void Start () {
		losingSound = GetComponent<AudioSource> ();
		playGameOverSound ();
	}

	public void playGameOverSound(){
		losingSound.Play ();
	}
}
