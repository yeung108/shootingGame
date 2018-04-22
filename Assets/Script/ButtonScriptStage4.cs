using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScriptStage4 : MonoBehaviour {
	public Material black;
	public Material red;
	public TextMesh threed;
	public GameObject uiobject;
	public GameObject uiobject2;
	public AudioSource correct;

	Renderer rend1;
	Renderer rend2;
	Renderer rend3;
	Renderer rend4;

	public GameObject b1;
	public GameObject b2;
	public GameObject b3;
	public GameObject b4;

	private bool b1Red = false;
	private bool b2Red = false;
	private bool b3Red = false;
	private bool b4Red = false;

	void Start(){
		rend1 = b1.GetComponent<Renderer> ();
		rend2 = b2.GetComponent<Renderer> ();
		rend3 = b3.GetComponent<Renderer> ();
		rend4 = b4.GetComponent<Renderer> ();
		rend1.material = black;
		rend2.material = black;
		rend3.material = black;
		rend4.material = black;
	}

	void Update () {
		if (!(b1Red && b2Red && b3Red && b4Red)) {
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
				if (raycastHit.collider.name == "b1") {
					Debug.Log ("b1 clicked");
					if (b2Red) {
						b2Red = !b2Red;
						rend2.material = black;
					} else {
						b2Red = !b2Red;
						rend2.material = red;
					}
					correctAnswer ();

				} else if (raycastHit.collider.name == "b2") {
					Debug.Log ("b2 clicked");
					if (b3Red) {
						b3Red = !b3Red;
						rend3.material = black;
					} else {
						b3Red = !b3Red;
						rend3.material = red;
					}
					if (b1Red) {
						b1Red = !b1Red;
						rend1.material = black;
					} else {
						b1Red = !b1Red;
						rend1.material = red;
					}
					correctAnswer ();

				} else if (raycastHit.collider.name == "b3") {
					Debug.Log ("b3 clicked");
					if (b2Red) {
						b2Red = !b2Red;
						rend2.material = black;
					} else {
						b2Red = !b2Red;
						rend2.material = red;
					}
					if (b4Red) {
						b4Red = !b4Red;
						rend4.material = black;
					} else {
						b4Red = !b4Red;
						rend4.material = red;
					}
					correctAnswer ();

				} else if (raycastHit.collider.name == "b4") {
					Debug.Log ("b4 clicked");
					if (b3Red) {
						b3Red = !b3Red;
						rend4.material = black;
					} else {
						b3Red = !b3Red;
						rend3.material = red;
					}
					correctAnswer ();
				}
			}
		}
	}

	void correctAnswer(){
		correct.Play ();
	}
}
