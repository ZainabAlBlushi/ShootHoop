using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public float timeTillNextLevel  = 0.0f;
	void Start () {
		
	}
	

	void Update () {
		if(timeTillNextLevel > 0){
		timeTillNextLevel -= Time.deltaTime;
		if (timeTillNextLevel < 0) {
			LoadNextScene ();
		}

	}
			}

	public void LoadNextScene(){
		//load the scenes
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		//load currentIndex +1
		SceneManager.LoadScene(currentIndex+1); 
	}

	public void LoadPrevoisScene(){
		//load the scenes
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		//load currentIndex +1
		SceneManager.LoadScene(currentIndex-1); 
	}
}
