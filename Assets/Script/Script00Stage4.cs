using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script00Stage4 : MonoBehaviour {
	public Material white;
	public Material red;
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
	public GameObject uiobject;
	public GameObject uiobject2;
	public AudioSource correct;
	public AudioSource wrong;

	Renderer rend1;
	Renderer rend2;
	Renderer rend3;
	Renderer rend4;
	Renderer rend5;
	Renderer rend6;
	Renderer rend7;
	Renderer rend8;
	Renderer rend9;

	private string answer = "";
	private int next = 1;

	// Use this for initialization
	void Start () {
		answer = "";
		rend1 = a1.GetComponent<Renderer> ();
		rend2 = a2.GetComponent<Renderer> ();
		rend3 = a3.GetComponent<Renderer> ();
		rend4 = a4.GetComponent<Renderer> ();
		rend5 = a5.GetComponent<Renderer> ();
		rend6 = a6.GetComponent<Renderer> ();
		rend7 = a7.GetComponent<Renderer> ();
		rend8 = a8.GetComponent<Renderer> ();
		rend9 = a9.GetComponent<Renderer> ();
		rend1.material = white;
		rend2.material = white;
		rend3.material = white;
		rend4.material = white;
		rend5.material = white;
		rend6.material = white;
		rend7.material = white;
		rend8.material = white;
		rend9.material = white;
	}



	
	// Update is called once per frame
	void Update () {
		if (answer != "123456789") {
			TapSelected ();
		} else {
			threed.text = "Unlocked";
			threed.color = Color.green;
			uiobject.SetActive (true);
			uiobject2.SetActive (true);
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
						correctAnswer ();
						rend1.material = red;
					} else {
						next = 1;
						answer = "";
						Debug.Log ("Wrong!");
						wrongAnswer ();
					}
				} else if (raycastHit.collider.name == "a2") {
					if (next == 2) {
						answer += "2";
						next++;
						correctAnswer ();
						rend2.material = red;
					} else {
						next = 1;
						answer = "";
						Debug.Log ("Wrong!");
						wrongAnswer ();
					}
				} else if (raycastHit.collider.name == "a3") {
					if (next == 3) {
						answer += "3";
						next++;
						correctAnswer ();
						rend3.material = red;
					} else {
						next = 1;
						answer = "";
						Debug.Log ("Wrong!");
						wrongAnswer ();
					}
				} else if (raycastHit.collider.name == "a4") {
					if (next == 4) {
						answer += "4";
						next++;
						correctAnswer ();
						rend4.material = red;
					} else {
						next = 1;
						answer = "";
						Debug.Log ("Wrong!");
						wrongAnswer ();
					}
				} else if (raycastHit.collider.name == "a5") {
					if (next == 5) {
						answer += "5";
						next++;
						correctAnswer ();
						rend5.material = red;
					} else {
						next = 1;
						answer = "";
						Debug.Log ("Wrong!");
						wrongAnswer ();
					}
				} else if (raycastHit.collider.name == "a6") {
					if (next == 6) {
						answer += "6";
						next++;
						correctAnswer ();
						rend6.material = red;
					} else {
						next = 1;
						answer = "";
						Debug.Log ("Wrong!");
						wrongAnswer ();
					}
				} else if (raycastHit.collider.name == "a7") {
					if (next == 7) {
						answer += "7";
						next++;
						correctAnswer ();
						rend7.material = red;
					} else {
						next = 1;
						answer = "";
						Debug.Log ("Wrong!");
						wrongAnswer ();
					}
				} else if (raycastHit.collider.name == "a8") {
					if (next == 8) {
						answer += "8";
						next++;
						correctAnswer ();
						rend8.material = red;
					} else {
						next = 1;
						answer = "";
						Debug.Log ("Wrong!");
						wrongAnswer ();
					}
				} else if (raycastHit.collider.name == "a9") {
					if (next == 9) {
						answer += "9";
						next++;
						correctAnswer ();
						rend9.material = red;
					} else {
						next = 1;
						answer = "";
						Debug.Log ("Wrong!");
						wrongAnswer ();
					}
				}
			}
		}
	}

	void correctAnswer(){
		correct.Play ();
	}

	void wrongAnswer(){
		wrong.Play ();
		rend1.material = white;
		rend2.material = white;
		rend3.material = white;
		rend4.material = white;
		rend5.material = white;
		rend6.material = white;
		rend7.material = white;
		rend8.material = white;
		rend9.material = white;
	}
}
