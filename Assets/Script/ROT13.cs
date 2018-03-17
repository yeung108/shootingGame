using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class ROT13 : MonoBehaviour {
	public Text output;
	public InputField inputF;

	void Update(){
		ROTD (inputF.text);
	}


	public void ROTD (string input)
	{
		output.text = !string.IsNullOrEmpty(input) ? new string (input.ToCharArray().Select(s =>  { return (char)(( s >= 97 && s <= 122 ) ? ( (s + 13 > 122 ) ? s - 13 : s + 13) : ( s >= 65 && s <= 90 ? (s + 13 > 90 ? s - 13 : s + 13) : s )); }).ToArray() ) : input;            
	}
}
