using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerStage3 : MonoBehaviour {

	public GameObject answerMenu;

	public TextMesh threed00;
	public TextMesh threed01;
	public TextMesh threed10;
	public TextMesh threed11;


	void Update(){
		if ((threed00.text == "Unlocked") && (threed01.text == "Unlocked") && (threed10.text == "Unlocked") && (threed11.text == "Unlocked")) {
			answerMenu.SetActive (true);
		}
	}
}
