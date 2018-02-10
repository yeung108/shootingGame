using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Vuforia;

public class tapDetection : MonoBehaviour {
	public GameObject bullet;
	public GameObject cam;
	public float damage = 10f;
	public float range = 10f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		TapSelected ();
		checkIfPlayerDie ();
	}

	void TapSelected() {
		if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
		{
			Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit raycastHit;
			if (Physics.Raycast(raycast, out raycastHit))
			{
				if (raycastHit.collider.name == "AK-47")
				{
					Debug.Log ("AK-47 clicked");
					Shoot ();
				} 
			}
		}
	}

	void Shoot(){
		Destroy(Instantiate (bullet, cam.transform.position, cam.transform.rotation), range);
		RaycastHit hit;
		if (Physics.Raycast (cam.transform.position, cam.transform.forward, out hit, range)) {
			Debug.Log (hit.transform.name);
		}
	}

	void checkIfPlayerDie(){
		if (SaveManager.Instance.state.health <= 0) {
			Initiate.Fade ("gameover", Color.black, 1f);
		}
	}
}
