using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ASCII : MonoBehaviour {
	public InputField input;
	public Text output;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		string inputtext = input.text;
		int numOfBytes = inputtext.Length / 8;
		byte[] bytes = new byte[numOfBytes];
		for(int i = 0; i < numOfBytes; ++i)
		{
			bytes[i] = Convert.ToByte(inputtext.Substring(8 * i, 8), 2);
		}
		output.text = System.Text.Encoding.ASCII.GetString(bytes);
	}
}
