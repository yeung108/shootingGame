using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ChangeStage : MonoBehaviour {
	public void nextStage() {
		String currentStage = "stage" + (SaveManager.Instance.state.currentStage + 1).ToString();
		SaveManager.Instance.state.currentStage++;
		SaveManager.Instance.Save ();
		Initiate.Fade (currentStage, Color.black, 1f);
	}
	public void previousStage() {
		String currentStage = "stage" + (SaveManager.Instance.state.currentStage - 1).ToString();
		SaveManager.Instance.state.currentStage--;
		SaveManager.Instance.Save ();
		Initiate.Fade (currentStage, Color.black, 1f);
	}
	public void badEnd() {
		String currentStage = "badEnd";
		SaveManager.Instance.state.currentStage = -1;
		SaveManager.Instance.Save ();
		Initiate.Fade (currentStage, Color.black, 1f);
	}
}