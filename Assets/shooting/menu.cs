using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {
	public GameObject pauseMenu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
		{
			Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit raycastHit;
			if (Physics.Raycast(raycast, out raycastHit))
			{
				if (raycastHit.collider.name == "menu")
				{
					Debug.Log ("menu clicked");
					PauseGame();
				} 
			}
		}
	}

	public void PauseGame()
	{
		Time.timeScale = 0;
		pauseMenu.SetActive(true);
		//Disable scripts that still work while timescale is set to 0
	}

	public void ContinueGame()
	{
		Time.timeScale = 1;
		pauseMenu.SetActive(false);
		//enable the scripts again
	}
}
