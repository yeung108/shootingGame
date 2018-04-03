using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemScriptStage3 : MonoBehaviour {
	public GameObject itemBig;
	RawImage currentImage;

	void Start(){
		currentImage = GameObject.Find ("paper00Click").GetComponent<RawImage> ();
		Debug.Log ("success");
	}

	void Update () {
		TapSelected ();
	}

	void TapSelected() {
		if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
		{
			Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit raycastHit;
			if (Physics.Raycast(raycast, out raycastHit))
			{
				if (raycastHit.collider.name == "paper00Click") {
					Debug.Log ("item clicked");
					currentImage = GameObject.Find ("paper00Click").GetComponent<RawImage> ();
					openBig ();
				} else if (raycastHit.collider.name == "paper01Click"){
					Debug.Log ("item clicked");
					currentImage = GameObject.Find ("paper01Click").GetComponent<RawImage> ();
					openBig ();
				} else if (raycastHit.collider.name == "paper10Click"){
					Debug.Log ("item clicked");
					currentImage = GameObject.Find ("paper10Click").GetComponent<RawImage> ();
					openBig ();
				} else if (raycastHit.collider.name == "morseCode00Click"){
					Debug.Log ("item clicked");
					currentImage = GameObject.Find ("morseCode00Click").GetComponent<RawImage> ();
					openBig ();
				} else if (raycastHit.collider.name == "morseCode01Click"){
					Debug.Log ("item clicked");
					currentImage = GameObject.Find ("morseCode01Click").GetComponent<RawImage> ();
					openBig ();
				} else if (raycastHit.collider.name == "morseCode10Click"){
					Debug.Log ("item clicked");
					currentImage = GameObject.Find ("morseCode10Click").GetComponent<RawImage> ();
					openBig ();
				} else if (raycastHit.collider.name == "morseCode11Click"){
					Debug.Log ("item clicked");
					currentImage = GameObject.Find ("morseCode11Click").GetComponent<RawImage> ();
					openBig ();
				} else if (raycastHit.collider.name == "HintsClick"){
					Debug.Log ("item clicked");
					currentImage = GameObject.Find ("HintsClick").GetComponent<RawImage> ();
					openBig ();
				} else {
					closeBig ();
				}
			}
		}
	}

	void openBig(){
		RawImage itemBigImage = itemBig.GetComponent<RawImage> ();
		itemBigImage.texture = currentImage.texture;
		itemBig.SetActive (true);
	}

	void closeBig(){
		itemBig.SetActive (false);
	}
}
