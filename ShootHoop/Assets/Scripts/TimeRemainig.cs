using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeRemainig : MonoBehaviour {

	LevelManager levelManager;
	Text text;

	void Start () {
		text=GetComponent<Text> ();
		levelManager = FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Time Remainging : " + levelManager.timeTillNextLevel;
	}
}
