using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickScript : MonoBehaviour {
	public GameObject answerMenu;

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
				if (raycastHit.collider.name == "chestbox") {
					Debug.Log ("chestbox clicked");
					openmenu ();
				} else {
					closemenu ();
				}
			}
		}
	}

	void openmenu(){
		answerMenu.SetActive (true);
	}

	void closemenu(){
		answerMenu.SetActive (false);
	}
}
