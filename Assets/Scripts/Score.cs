using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int score;
	[SerializeField]
	private Text scoreText;

	public void ScoreUpdate () {
		scoreText.text=string.Format("Score: ")+ score.ToString();
	}

}
