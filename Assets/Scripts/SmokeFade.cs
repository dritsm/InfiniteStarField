using UnityEngine;
using System.Collections;

public class SmokeFade : MonoBehaviour 
{
	public float fadeSpeed = 0f;
	public float fadeTime = .5f;

	private SpriteRenderer spriteRenderer;
	private AudioSource boomSound;


	// Use this for initialization
	void Start () 
	{
		boomSound = GetComponent<AudioSource> ();
		spriteRenderer = GetComponent<SpriteRenderer> ();
		spriteRenderer.color = new Color (1f, 1f, 1f, 1f);

		boomSound.Play ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float fade = Mathf.SmoothDamp (spriteRenderer.color.a, 0f, ref fadeSpeed, fadeTime); //ref means value is passed in and will change over time to fade out
		spriteRenderer.color = new Color (1f, 1f, 1f, fade);			
	}
}
