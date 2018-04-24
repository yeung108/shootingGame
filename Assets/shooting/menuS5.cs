using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuS5 : MonoBehaviour {
	public GameObject menuCanvas;
	public GameObject menuButton;
	// Update is called once per frame
	void Update () {
		if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
		{
			Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit raycastHit;
			if (Physics.Raycast(raycast, out raycastHit))
			{
				if (raycastHit.collider.name == "menu")
				{
					Debug.Log ("menu clicked");
					toMenu ();
				} 
			}
		}
	}

	void toMenu() {
		menuCanvas.SetActive (true);
		menuButton.SetActive (false);
	}
}
