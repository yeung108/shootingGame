using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer : MonoBehaviour {

	public InputField input;
	public Button button;
	public TextMesh threed;

	void Start()
	{
		button.onClick.AddListener(Checked);
	}
	void Wrong(){
		print ("Wrong");
	}
	void Checked(){
		if (input.text == "01453") {
			threed.text = "Unlocked";
			threed.color = Color.green;
		} else {
			Debug.Log ("Wrong");
		}
	}
}
