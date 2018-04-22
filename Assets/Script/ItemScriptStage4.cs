using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemScriptStage4 : MonoBehaviour {
	public GameObject itemBig;
	RawImage currentImage;
	public GameObject exitButton;

	void Start(){
		currentImage = GameObject.Find ("clockClick").GetComponent<RawImage> ();
		Debug.Log ("success");
	}

	void openBig(){
		RawImage itemBigImage = itemBig.GetComponent<RawImage> ();
		itemBigImage.texture = currentImage.texture;
		itemBig.SetActive (true);
		exitButton.SetActive (true);
	}

	public void buttonPressed(string name){
		if (name == "clock") {
			Debug.Log ("item clicked");
			currentImage = GameObject.Find ("clockClick").GetComponent<RawImage> ();
			openBig ();
		} else if (name == "hints"){
			Debug.Log ("item clicked");
			currentImage = GameObject.Find ("hintsClick").GetComponent<RawImage> ();
			openBig ();
		} else if (name == "hints2"){
			Debug.Log ("item clicked");
			currentImage = GameObject.Find ("hints2Click").GetComponent<RawImage> ();
			openBig ();
		}
	}

	public void solveHidden(){
		SaveManager.Instance.state.hiddenSolvedS4 = true;
		SaveManager.Instance.Save ();
	}
}
