using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectScoring : MonoBehaviour {

	public int scorePerHit = 1;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision){
		ScoreKepper scoreKepper = FindObjectOfType<ScoreKepper> ();
		scoreKepper.IncrementScore (scorePerHit);
	}
}
