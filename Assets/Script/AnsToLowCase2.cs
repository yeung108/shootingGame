using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnsToLowCase2 : MonoBehaviour {
	public InputField inputF;
	public Text output;

	public void submitAnswer(){
		string tempString = inputF.text.ToLower();
		tempString = tempString.Replace (" ", string.Empty);
		inputF.text = "";
		output.text = tempString;
	}
}
