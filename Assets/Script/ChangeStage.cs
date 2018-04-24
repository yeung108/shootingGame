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
		Initiate.Fade (currentStage, Color.black, 1f);
	}
	public void normalEnd(){
		String currentStage = "normalEnd";
		Initiate.Fade (currentStage, Color.black, 1f);
	}
	public void tureEnd(){
		String currentStage = "trueEnd";
		Initiate.Fade (currentStage, Color.black, 1f);
	}
}