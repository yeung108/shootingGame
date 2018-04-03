using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script10Stage4 : MonoBehaviour {
	public TextMesh threed;
	public GameObject uiobject;

	private string answer = "";
	private string[] array = {"3", "1", "4"};
	private int time = 0;
	private string next = "";

	// Use this for initialization
	void Start () {
		answer = "";
		time = 0;
		next = array [time];
	}

	// Update is called once per frame
	void Update () {
		if (answer != "314") {
			TapSelected ();
		} else {
			threed.text = "Unlocked";
			threed.color = Color.green;
			uiobject.SetActive (true);
		}
	}

	void TapSelected() {
		if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
		{
			Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit raycastHit;
			if (Physics.Raycast (raycast, out raycastHit)) {
				if (raycastHit.collider.name == "1") {
					if (next == "1") {
						answer += "1";
						time++;
					} else {
						time = 0;
						answer = "";
						Debug.Log ("Wrong!");
					}
				} else if (raycastHit.collider.name == "2") {
					if (next == "2") {
						answer += "2";
						time++;
					} else {
						time = 0;
						answer = "";
						Debug.Log ("Wrong!");
					}
				} else if (raycastHit.collider.name == "3") {
					if (next == "3") {
						answer += "3";
						time++;
					} else {
						time = 0;
						answer = "";
						Debug.Log ("Wrong!");
					}
				} else if (raycastHit.collider.name == "4") {
					if (next == "4") {
						answer += "4";
						time++;
					} else {
						time = 0;
						answer = "";
						Debug.Log ("Wrong!");
					}
				} else if (raycastHit.collider.name == "5") {
					if (next == "5") {
						answer += "5";
						time++;
					} else {
						time = 0;
						answer = "";
						Debug.Log ("Wrong!");
					}
				} else if (raycastHit.collider.name == "6") {
					if (next == "6") {
						answer += "6";
						time++;
					} else {
						time = 0;
						answer = "";
						Debug.Log ("Wrong!");
					}
				} else if (raycastHit.collider.name == "7") {
					if (next == "7") {
						answer += "7";
						time++;
					} else {
						time = 0;
						answer = "";
						Debug.Log ("Wrong!");
					}
				} else if (raycastHit.collider.name == "8") {
					if (next == "8") {
						answer += "8";
						time++;
					} else {
						time = 0;
						answer = "";
						Debug.Log ("Wrong!");
					}
				} else if (raycastHit.collider.name == "9") {
					if (next == "9") {
						answer += "9";
						time++;
					} else {
						time = 0;
						answer = "";
						Debug.Log ("Wrong!");
					}
				}
			}
		}
	}
}
