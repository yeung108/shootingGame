using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script01Stage4 : MonoBehaviour {
	public TextMesh threed;
	public GameObject up;
	public GameObject down;
	public GameObject left;
	public GameObject right;
	public GameObject uiobject;
	public GameObject uiobject2;
	public AudioSource correct;
	public AudioSource wrong;

	private string answer = "";
	private char[] array = {'r','r','d','l','d','d','r'};
	private string array2 = "rrdlddr";
	private int time = 0;
	private char next;

	// Use this for initialization
	void Start () {
		answer = "";
		time = 0;
		next = array [time];
	}

	// Update is called once per frame
	void Update () {
		if (answer != array2) {
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
				if (raycastHit.collider.name == "up") {
					time = 0;
					answer = "";
					next = array [time];
					Debug.Log ("Wrong!");
					wrongAnswer ();
				} else if (raycastHit.collider.name == "down") {
					if (next == 'd') {
						time++;
						answer += "d";
						next = array [time];
						correctAnswer ();
					} else {
						time = 0;
						answer = "";
						next = array [time];
						Debug.Log ("Wrong!");
						wrongAnswer ();
					}
				} else if (raycastHit.collider.name == "left") {
					if (next == 'l') {
						time++;
						answer += "l";
						next = array [time];
						correctAnswer ();
					} else {
						time = 0;
						answer = "";
						next = array [time];
						Debug.Log ("Wrong!");
						wrongAnswer ();
					}
				} else if (raycastHit.collider.name == "right") {
					if (next == 'r') {
						time++;
						answer += "r";
						next = array [time];
						correctAnswer ();
					} else {
						time = 0;
						answer = "";
						next = array [time];
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
	}
}
