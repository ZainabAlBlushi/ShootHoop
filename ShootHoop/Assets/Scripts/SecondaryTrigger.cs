using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryTrigger : MonoBehaviour {

	Collider expectedCollider;

	public void ExpectCollider(Collider collider){
		expectedCollider = collider;
	}

	void OnTriggerEnter(Collider otherCollider){
		if (otherCollider == expectedCollider) {
			ScoreKepper scoreKepper = FindObjectOfType<ScoreKepper> ();
			scoreKepper.IncrementScore (1);
		}
	}
}
