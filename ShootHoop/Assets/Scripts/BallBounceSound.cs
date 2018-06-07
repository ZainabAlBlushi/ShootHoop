using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounceSound : MonoBehaviour {

	void OnCollisonEnter(Collision collision){
		AudioSource source = GetComponent<AudioSource> ();
		source.Play ();
	}

}
