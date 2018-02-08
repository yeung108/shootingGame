using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour {

	public static SaveManager Instance { get; set; }
	public SaveState state;

	private void Awake(){
		DontDestroyOnLoad(gameObject);
		Instance = this;
	}

	public void Save(){
		PlayerPrefs.SetString ("save", Helper.Serialize<SaveState>(state));
	}

	public void Load(){
		if (PlayerPrefs.HasKey ("save")) {
			state = Helper.Deserialize<SaveState> (PlayerPrefs.GetString ("save"));
		} else {
			state = new SaveState ();
			Save ();
			Debug.Log ("No save file found, creating a new one");
		}
	}

	public void New(){
		if (PlayerPrefs.HasKey ("save")) {
			PlayerPrefs.DeleteKey("save");
		} 
		Load ();
	}
}
