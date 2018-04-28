using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerCheckerForHiddenPuzzleImageTaregt : MonoBehaviour {
	public GameObject thankYouText;
	public InputField inputF;

	public void checkAnswer () {
		string tempString = inputF.text.ToLower();
		tempString = tempString.Replace (" ", string.Empty);
		inputF.text = "";
		if (tempString == "thanks") {
			thankYouText.SetActive (true);
		}
	}
}
