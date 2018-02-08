using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour {

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
		Initiate.Fade ("shooting", Color.black, 1f);
	}

	public void QuitGame(){
		Application.Quit ();
	}
}
