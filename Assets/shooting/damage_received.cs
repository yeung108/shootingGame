using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class damage_received : MonoBehaviour {

	void OnTriggerEnter(Collider bullet){
		Debug.Log ("Collision object");
		if (bullet.tag == "bullet") {
			Destroy (gameObject);
			Debug.Log ("Destroy object");
		}
	}
}
