using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class bullet_movement : MonoBehaviour {
	private float speed = 15f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject != null) {
			transform.Translate (Vector3.forward * Time.deltaTime * speed);
			//Debug.Log ("Bullet Position: "+transform.position);
			if (Vector3.Distance (transform.position, GameObject.Find("target").transform.position) >= 10.0f) {
				Destroy(gameObject);
			};
		}
	}
}
