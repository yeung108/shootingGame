using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour {

	void Start (){
		if (SaveManager.Instance.state.gear) {
			GameObject.Find ("gear").SetActive (true);
		} else {
			GameObject.Find ("gear").SetActive (false);
		}
	}

	public void getItem(){
		GameObject.Find ("gear").SetActive(true);
		SaveManager.Instance.state.gear = true;
	}
}
