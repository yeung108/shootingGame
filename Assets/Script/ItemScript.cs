using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour {

	public GameObject gear;

	void Start (){
		if (SaveManager.Instance.state.gear) {
			gear.SetActive (true);
		} else {
			gear.SetActive (false);
		}
	}

	public void getItem(){
		GameObject.Find ("gear").SetActive(true);
		SaveManager.Instance.state.gear = true;
		SaveManager.Instance.state.hiddenSolvedS1 = true;
		SaveManager.Instance.Save ();
	}
}
