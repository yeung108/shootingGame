using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Vuforia;

public class weapon_switching : MonoBehaviour {

	public int selectedWeapon = 0;
	//public Transform weaponholder;

	// Use this for initialization
	void Start () {
		SelectWeapon ();
	}

	// Update is called once per frame
	void Update()
	{

		int previousSelectedWeapon = selectedWeapon;

		TapSelected ();

		if (previousSelectedWeapon != selectedWeapon) {
			SelectWeapon ();
		}
	}

	void TapSelected() {
		if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
		{
			Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit raycastHit;
			if (Physics.Raycast(raycast, out raycastHit))
			{
				if (raycastHit.collider.name == "rightArrow")
				{
					Debug.Log ("rightArrow clicked");
					selectNextWeapon();
				} else if (raycastHit.collider.name == "leftArrow")
				{
					Debug.Log ("leftArrow clicked");
					selectPreviousWeapon();
				}
			}
		}
	}

	void selectNextWeapon() {
		if (selectedWeapon >= transform.childCount - 1)
			selectedWeapon = 0;
		else
			selectedWeapon++;
	}

	void selectPreviousWeapon() {
		if (selectedWeapon <= 0)
			selectedWeapon = transform.childCount - 1;
		else
			selectedWeapon--;
	}

	void SelectWeapon() {
		int i = 0;
		foreach (Transform weapon in transform) {
			if (i == selectedWeapon) {
				weapon.gameObject.SetActive (true);
				Debug.Log ("Here is weapon number" + selectedWeapon);
			}
			else
				weapon.gameObject.SetActive (false);
			i++;
		}
	}
}
