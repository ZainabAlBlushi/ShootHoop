using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

	Text text;
	ScoreKepper scoreKeeper;
	void Start () {
		scoreKeeper = FindObjectOfType<ScoreKepper> ();
		text=GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		text.text = "Score : " + scoreKeeper.score;
	}
}
