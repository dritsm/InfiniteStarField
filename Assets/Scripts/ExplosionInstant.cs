using UnityEngine;
using System.Collections;

public class ExplosionInstant : MonoBehaviour {

	public GameObject explosion;
	GameObject explosionClone;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void lifeExploder(){
		if (
	
			explosionClone = Instantiate (explosion, transform.position, transform.rotation) as GameObject);
		Destroy (explosionClone, 1f);
	}
}
