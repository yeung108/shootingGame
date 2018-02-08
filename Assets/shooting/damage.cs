using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class damage : MonoBehaviour {

	void OnTriggerEnter(Collider sth){
		Debug.Log ("Collision bullet");
		if (sth.tag == "object") {
			Destroy (gameObject);
			Debug.Log ("Destroy bullet");
		} else if (sth.tag == "dragon") {
			Debug.Log ("Bullet Collide position: "+transform.position);
			Destroy (gameObject);
			Debug.Log ("Destroy dragon");
		}
	}
}
