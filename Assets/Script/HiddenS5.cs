using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenS5: MonoBehaviour {

	public GameObject talkButton;

	void Start (){
		if (SaveManager.Instance.state.hiddenSolvedS1 && SaveManager.Instance.state.hiddenSolvedS2 && SaveManager.Instance.state.hiddenSolvedS3 && SaveManager.Instance.state.hiddenSolvedS4) {
			talkButton.SetActive (true);
		} else {
			talkButton.SetActive (false);
		}
	}
}
