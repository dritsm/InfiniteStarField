//This script increments score text

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIScript : MonoBehaviour 
{
	public Text ScoreText;
	private int score = 0;

	public void IncrementShots()
	{
		ScoreText.text = string.Format("Score: {0}", score += 10);
	}
}
