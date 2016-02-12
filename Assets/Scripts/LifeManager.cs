using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LifeManager : MonoBehaviour {
	public int startingLives;
	public string mainMenu;
	public float waitAfterGameOver = 4f;

	public GameObject gameOverScreen;

	public AudioSource lifeLostSound;
	public AudioSource losingSound;
	public AudioSource burningSound;


	private int lifeCounter;
	private bool gameOver = false;
	private Text theText;


	// Use this for initialization
	void Start () {

		lifeLostSound = GetComponent<AudioSource> ();
		losingSound = GetComponent<AudioSource> ();
		burningSound = GetComponent<AudioSource> ();

		theText = GetComponent<Text> ();
		lifeCounter = startingLives;
	}

	void Update(){
		if (lifeCounter < 1) 
		{
			gameOverScreen.SetActive (true);
			burningSound.Play ();

			Time.timeScale = 0;
		}

		theText.text = "x " + lifeCounter;

		if (gameOverScreen.activeSelf)
		{
			waitAfterGameOver -= Time.deltaTime;
		}

		if (waitAfterGameOver < 0) 
		{
			Application.LoadLevel (mainMenu);
		}
		
	}

	public void takeLife()
	{
		if (lifeCounter > 0 &&!gameOver)
		{
			lifeCounter--;
			lifeLostSound.Play ();

		}
	}
}
