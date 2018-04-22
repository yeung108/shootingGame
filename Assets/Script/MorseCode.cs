using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class MorseCode : MonoBehaviour {

	public void buttonClick (){
		Text inputF = GameObject.Find("MorseCodeInput").GetComponent<Text>();
		translate (inputF.text);
	}

	void translate (string input){
		Text output = GameObject.Find ("MorseCodeOutput").GetComponent<Text> ();
		output.text = "";
		if (!string.IsNullOrEmpty (input)) {
			Dictionary<string, char> morse = new Dictionary<string, char> () {
				{ ".-", 'A' },
				{ "-...", 'B' },
				{ "-.-.", 'C' },
				{ "-..", 'D' },
				{ ".", 'E' },
				{ "..-.", 'F' },
				{ "--.", 'G' },
				{ "....", 'H' },
				{ "..", 'I' },
				{ ".---", 'J' },
				{ "-.-", 'K' },
				{ ".-..", 'L' },
				{ "--", 'M' },
				{ "-.", 'N' },
				{ "---", 'O' },
				{ ".--.", 'P' },
				{ "--.-", 'Q' },
				{ ".-.", 'R' },
				{ "...", 'S' },
				{ "-", 'T' },
				{ "..-", 'U' },
				{ "...-", 'V' },
				{ ".--", 'W' },
				{ "-..-", 'X' },
				{ "-.--", 'Y' },
				{ "--..", 'Z' },
				{ "-----", '0' },
				{ ".----", '1' },
				{ "..---", '2' },
				{ "...--", '3' },
				{ "....-", '4' },
				{ ".....", '5' },
				{ "-....", '6' },
				{ "--...", '7' },
				{ "---..", '8' },
				{ "----.", '9' },
			};

			int inputLength = input.Length;
			string prepareToAnswer = "";

			for (int i = 0; i < inputLength; i++) {
				
				if (input [i] != ' ') {
					prepareToAnswer += input [i];
				} else {
					output.text += morse [prepareToAnswer];
					output.text += " ";
					prepareToAnswer = "";
				}

			}

			output.text += morse [prepareToAnswer];
			prepareToAnswer = "";
		}
	}
}
