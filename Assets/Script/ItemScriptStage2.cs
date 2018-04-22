using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScriptStage2: MonoBehaviour {

	public GameObject gear;

	void Start (){
		if (SaveManager.Instance.state.gear) {
			gear.SetActive (true);
		} else {
			gear.SetActive (false);
		}
	}

	public void solveHidden(){
		SaveManager.Instance.state.hiddenSolvedS2 = true;
		SaveManager.Instance.Save ();
	}
}
