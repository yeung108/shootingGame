#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class MainMenu : MonoBehaviour {

	public void toMenu() {
		Initiate.Fade ("menu", Color.black, 1f);
	}

}
#endif