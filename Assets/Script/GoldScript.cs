using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Fungus;

public class GoldScript : MonoBehaviour {

	public GameObject goldTextObject;
	public int hintsPrice = 50;
	public Flowchart flowChart;

	// Update is called once per frame
	void Update () {
		goldTextObject.GetComponent<TextMeshProUGUI> ().text = "$" + SaveManager.Instance.state.gold;
		flowChart.SetIntegerVariable ("gold", SaveManager.Instance.state.gold);
	}

	public void buyHints(){
		SaveManager.Instance.state.gold -= hintsPrice;
		SaveManager.Instance.Save ();
	}

}
