using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour {

	public void PlayGame(){
		Initiate.Fade ("shooting", Color.black, 1f);
		//SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void QuitGame(){
		Application.Quit ();
	}
}
