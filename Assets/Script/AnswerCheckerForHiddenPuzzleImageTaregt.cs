using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerCheckerForHiddenPuzzleImageTaregt : MonoBehaviour {
	public GameObject thankYouText;
	public InputField inputF;

	public void checkAnswer () {
		if (inputF.text == "THANKS") {
			thankYouText.SetActive (true);
		}
	}
}
