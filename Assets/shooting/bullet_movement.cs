using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class bullet_movement : MonoBehaviour {
	private float speed = 15f;
	public GameObject target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * speed);
		//Debug.Log ("Bullet Position: "+transform.position);
		if (Vector3.Distance (transform.position, target.transform.position) >= 10.0f) {
			Destroy(gameObject);
		};
	}
}
