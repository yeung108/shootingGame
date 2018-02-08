using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Vuforia;

public class create_bullet : MonoBehaviour {
	public GameObject bullet;
	public GameObject cam;
	public float damage = 10f;
	public float range = 20f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//TapSelected ();
		/*if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
		{
			Instantiate (bullet, cam.transform.position, cam.transform.rotation);
			RaycastHit hit;
			if (Physics.Raycast (cam.transform.position, cam.transform.forward, out hit, range)) {
				Debug.Log (hit.transform.name);
			}
		}*/
	}

	void TapSelected() {
		if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
		{
			Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit raycastHit;
			if (Physics.Raycast(raycast, out raycastHit))
			{
				Debug.Log("Something Hit");
				if (raycastHit.collider.name == "bubble")
				{
					Debug.Log("bubble clicked");
				}
			}
		}
	}
}
