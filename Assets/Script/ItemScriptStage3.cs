using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemScriptStage3 : MonoBehaviour {
	public GameObject itemBig;
	RawImage currentImage;
	public GameObject exitButton;

	void Start(){
		currentImage = GameObject.Find ("paper00Click").GetComponent<RawImage> ();
		Debug.Log ("success");
	}

	void openBig(){
		RawImage itemBigImage = itemBig.GetComponent<RawImage> ();
		itemBigImage.texture = currentImage.texture;
		itemBig.SetActive (true);
		exitButton.SetActive (true);
	}
		
	public void buttonPressed(string name){
		if (name == "paper00") {
			Debug.Log ("item clicked");
			currentImage = GameObject.Find ("paper00Click").GetComponent<RawImage> ();
			openBig ();
		} else if (name == "paper01"){
			Debug.Log ("item clicked");
			currentImage = GameObject.Find ("paper01Click").GetComponent<RawImage> ();
			openBig ();
		} else if (name == "paper10"){
			Debug.Log ("item clicked");
			currentImage = GameObject.Find ("paper10Click").GetComponent<RawImage> ();
			openBig ();
		} else if (name == "morseCode00"){
			Debug.Log ("item clicked");
			currentImage = GameObject.Find ("morseCode00Click").GetComponent<RawImage> ();
			openBig ();
		} else if (name == "morseCode01"){
			Debug.Log ("item clicked");
			currentImage = GameObject.Find ("morseCode01Click").GetComponent<RawImage> ();
			openBig ();
		} else if (name == "morseCode10"){
			Debug.Log ("item clicked");
			currentImage = GameObject.Find ("morseCode10Click").GetComponent<RawImage> ();
			openBig ();
		} else if (name == "morseCode11"){
			Debug.Log ("item clicked");
			currentImage = GameObject.Find ("morseCode11Click").GetComponent<RawImage> ();
			openBig ();
		} else if (name == "Hints"){
			Debug.Log ("item clicked");
			currentImage = GameObject.Find ("HintsClick").GetComponent<RawImage> ();
			openBig ();
		}
	}

	public void solveHidden(){
		SaveManager.Instance.state.hiddenSolvedS3 = true;
		SaveManager.Instance.Save ();
	}
}
