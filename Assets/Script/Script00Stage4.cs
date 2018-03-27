using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script00Stage4 : MonoBehaviour {
	public TextMesh threed;
	public GameObject a1;
	public GameObject a2;
	public GameObject a3;
	public GameObject a4;
	public GameObject a5;
	public GameObject a6;
	public GameObject a7;
	public GameObject a8;
	public GameObject a9;

	private string answer = "";
	private int next = 1;

	// Use this for initialization
	void Start () {
		answer = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (answer != "123456789") {
			TapSelected ();
		} else {
			threed.text = "Unlocked";
			threed.color = Color.green;
		}
	}

	void TapSelected() {
		if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
		{
			Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit raycastHit;
			if (Physics.Raycast (raycast, out raycastHit)) {
				if (raycastHit.collider.name == "a1") {
					if (next == 1) {
						answer += "1";
						next++;
					} else {
						next = 1;
						answer = "";
						Debug.Log ("Wrong!");
					}
				} else if (raycastHit.collider.name == "a2") {
					if (next == 2) {
						answer += "2";
						next++;
					} else {
						next = 1;
						answer = "";
						Debug.Log ("Wrong!");
					}
				} else if (raycastHit.collider.name == "a3") {
					if (next == 3) {
						answer += "3";
						next++;
					} else {
						next = 1;
						answer = "";
						Debug.Log ("Wrong!");
					}
				} else if (raycastHit.collider.name == "a4") {
					if (next == 4) {
						answer += "4";
						next++;
					} else {
						next = 1;
						answer = "";
						Debug.Log ("Wrong!");
					}
				} else if (raycastHit.collider.name == "a5") {
					if (next == 5) {
						answer += "5";
						next++;
					} else {
						next = 1;
						answer = "";
						Debug.Log ("Wrong!");
					}
				} else if (raycastHit.collider.name == "a6") {
					if (next == 6) {
						answer += "6";
						next++;
					} else {
						next = 1;
						answer = "";
						Debug.Log ("Wrong!");
					}
				} else if (raycastHit.collider.name == "a7") {
					if (next == 7) {
						answer += "7";
						next++;
					} else {
						next = 1;
						answer = "";
						Debug.Log ("Wrong!");
					}
				} else if (raycastHit.collider.name == "a8") {
					if (next == 8) {
						answer += "8";
						next++;
					} else {
						next = 1;
						answer = "";
						Debug.Log ("Wrong!");
					}
				} else if (raycastHit.collider.name == "a9") {
					if (next == 9) {
						answer += "9";
						next++;
					} else {
						next = 1;
						answer = "";
						Debug.Log ("Wrong!");
					}
				}
			}
		}
	}
}
