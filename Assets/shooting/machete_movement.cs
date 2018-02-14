using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class machete_movement : MonoBehaviour {
	private float speed = 10f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (gameObject != null) {
			gameObject.SetActive (true);
			transform.localScale = new Vector3 (0.003f,0.003f,0.003f);
			transform.Translate (Vector3.forward * Time.deltaTime * speed);
			transform.eulerAngles += new Vector3 (1f, 0, 0);
			Debug.Log ("Knife Position: "+transform.position);
			if (Vector3.Distance (transform.position, GameObject.Find("target").transform.position) >= 10.0f) {
				Destroy(gameObject);
			};
		}
	}
}
