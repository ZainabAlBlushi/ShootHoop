using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScoreDisplay : MonoBehaviour {

	Text text;
	ScoreAbsorber scoreAbsorber;
	void Start () {
		scoreAbsorber = FindObjectOfType<ScoreAbsorber> ();
		text=GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {

		text.text = "Score : " + scoreAbsorber.score;
	}
}
