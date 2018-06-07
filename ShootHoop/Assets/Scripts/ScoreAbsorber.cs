using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAbsorber : MonoBehaviour {

	public int score;
	void Start () {
		ScoreKepper oldKepper = FindObjectOfType<ScoreKepper> ();
		score = 1;
		if (oldKepper) {
			score = oldKepper.score;
			Destroy (oldKepper.gameObject);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
