using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKepper : MonoBehaviour {

	public int score = 0;
	void Start () {
		DontDestroyOnLoad (gameObject);
	}

	void Update () {
		
	}

	public void IncrementScore (int amount){
		score += amount;
		AudioSource source = GetComponent<AudioSource> ();
		source.Play ();
	}
}
