using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ChangeStage : MonoBehaviour {
	public void nextStage() {
		String currentStage = "stage" + (SaveManager.Instance.state.currentStage + 1).ToString();
		Initiate.Fade (currentStage, Color.black, 1f);
	}
	public void previousStage() {
		String currentStage = "stage" + (SaveManager.Instance.state.currentStage - 1).ToString();
		Initiate.Fade (currentStage, Color.black, 1f);
	}
	public void badEnd() {
		Initiate.Fade ("badEnd", Color.black, 1f);
	}
}