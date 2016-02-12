using UnityEngine;
using System.Collections;

public class SecondGameOverScript : MonoBehaviour {

	public AudioSource burningSound;

	// Use this for initialization
	void Start () {
		burningSound = GetComponent<AudioSource> ();
		playSecondGameOverSound ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void playSecondGameOverSound(){
		burningSound.Play ();
	}
}
