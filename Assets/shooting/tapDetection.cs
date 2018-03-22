using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Vuforia;
using TMPro;

public class tapDetection : MonoBehaviour {
	public GameObject bullet;
	public GameObject cam;
	public GameObject knife;
	public GameObject hittedTextObject;
	public float damage = 10f;
	public float range = 10f;
	public float knifeRange = 10f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		TapSelected ();
		checkIfPlayerDie ();
		checkIfAllDragonDie ();
	}

	void TapSelected() {
		if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
		{
			Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit raycastHit;
			if (Physics.Raycast(raycast, out raycastHit))
			{
				if (raycastHit.collider.name == "AK-47") {
					Debug.Log ("AK-47 clicked");
					Shoot ();
				} else if (raycastHit.collider.name == "Machete") {
					Debug.Log ("Machete clicked");
					Slash ();
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

	void checkIfAllDragonDie(){
		var noOfDragonAlive = GameObject.FindGameObjectsWithTag ("dragon");
		if (noOfDragonAlive.Length == 0) {
			Initiate.Fade ("stage1", Color.black, 1f);
		} else {
			hittedTextObject.GetComponent<TextMeshProUGUI> ().text = "Enemies: " + noOfDragonAlive.Length;
		}
	}

	void Slash(){
		knife.SetActive (true);
		knife.transform.localScale = new Vector3 (0.003f,0.003f,0.003f);
		knife.transform.eulerAngles += new Vector3 (0, 5f, 0);
		Destroy(Instantiate (knife, cam.transform.position, cam.transform.rotation), knifeRange);
		Debug.Log ("Knife Position: "+transform.position);
		RaycastHit hit;
		if (Physics.Raycast (cam.transform.position, cam.transform.forward, out hit, knifeRange)) {
			Debug.Log (hit.transform.name);
		}
	}
}
