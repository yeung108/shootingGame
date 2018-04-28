using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameMenu : MonoBehaviour {

	public GameObject goldTextObject;
	public GameObject stageTextObject;
	public GameObject shopGoldTextObject;
	public int bulletPrice = 100;
	public int knifePrice = 50;

	public void PlayGame(){
		if (PlayerPrefs.HasKey ("save")) {
			PlayerPrefs.DeleteKey("save");
		} 
		SaveManager.Instance.New ();
		Initiate.Fade ("shooting", Color.black, 1f);
		//SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void LoadGame(){
		SaveManager.Instance.Load ();
		if (SaveManager.Instance.state.encounterDragon == true) {
			Initiate.Fade ("shooting", Color.black, 1f);
		} else {
			string sceneName = "stage" + SaveManager.Instance.state.currentStage;
			Initiate.Fade (sceneName, Color.black, 1f);
		} 
	}

	public void QuitGame(){
		Application.Quit ();
	}

	public void displayProgress(){
		SaveManager.Instance.Load ();
		goldTextObject.GetComponent<TextMeshProUGUI> ().text = "Gold: " + SaveManager.Instance.state.gold;
		stageTextObject.GetComponent<TextMeshProUGUI> ().text = "Stage: " + SaveManager.Instance.state.currentStage;
	}

	public void displayShop(){
		SaveManager.Instance.Load ();
		shopGoldTextObject.GetComponent<TextMeshProUGUI> ().text = "Gold: " + SaveManager.Instance.state.gold;
	}

	public void buyBullet(){
		SaveManager.Instance.Load ();
		if (SaveManager.Instance.state.gold >= bulletPrice) {
			SaveManager.Instance.state.gold -= bulletPrice;
			SaveManager.Instance.state.bullet += 100;
			SaveManager.Instance.Save ();
		}
		goldTextObject.GetComponent<TextMeshProUGUI> ().text = "Gold: " + SaveManager.Instance.state.gold;
	}

	public void buyKnife(){
		SaveManager.Instance.Load ();
		if (SaveManager.Instance.state.gold >= knifePrice) {
			SaveManager.Instance.state.gold -= knifePrice;
			SaveManager.Instance.state.knife += 50;
			SaveManager.Instance.Save ();
		}
		goldTextObject.GetComponent<TextMeshProUGUI> ().text = "Gold: " + SaveManager.Instance.state.gold;
	}
}
