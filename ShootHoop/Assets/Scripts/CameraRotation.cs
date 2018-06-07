using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
		float rotationSpeed = 2.0f;
		float maouseX = Input.GetAxis ("Mouse X") * rotationSpeed;
		float maouseY = Input.GetAxis ("Mouse Y") *rotationSpeed ;
		transform.localRotation = Quaternion.Euler (0f,maouseX,0f) * transform.localRotation ;
		Camera camera = GetComponentInChildren<Camera> ();
		camera.transform.localRotation = Quaternion.Euler (-maouseY,0f,0f) * camera.transform.localRotation ;
	}
}
