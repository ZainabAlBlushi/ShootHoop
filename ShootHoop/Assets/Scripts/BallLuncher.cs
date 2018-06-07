using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class BallLuncher : MonoBehaviour {

	public float ballSpeed = 5.0f;

	public GameObject ballPrefab;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			GameObject instance = Instantiate(ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			instance.transform.position = transform.position;
			Camera camera = GetComponentInChildren<Camera>();
			rb.velocity = camera.transform.rotation * Vector3.forward *ballSpeed;
		}
	}
}
