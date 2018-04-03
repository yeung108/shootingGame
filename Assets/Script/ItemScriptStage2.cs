using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScriptStage2: MonoBehaviour {

	void Start (){
		if (SaveManager.Instance.state.gear) {
			GameObject.Find ("gear").SetActive (true);
		} else {
			GameObject.Find ("gear").SetActive (false);
		}
	}
}
