using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickScriptForMusicBox : MonoBehaviour {
	public AudioSource morseCode;
	public GameObject gear;
	
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
				if ((raycastHit.collider.name == "MusicBox" ) && (SaveManager.Instance.state.gear)) {
					Debug.Log ("MusicBox clicked");
					playMusic();
					gear.SetActive (false);
				}
			}
		}
	}

	public void playMusic(){
		morseCode.Play ();
	}
}
