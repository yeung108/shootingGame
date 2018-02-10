using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using TMPro;

public class DragonControl : MonoBehaviour {

	public GameObject healthTextObject;
	public GameObject distanceTextObject;
	public GameObject hittedTextObject;
	public playerControl playercontrol;
	public GameObject target;
	public GameObject explosion;
	private Vector3 targetPosition;
	private int hitnumber = 0;
	private float speed = .01f;
	private int dragonLife = 10;
	private float attackRange = 6.0f;

	IEnumerator DestroyDragon(float time)
	{
		yield return new WaitForSeconds(time);
		explosion.PositionAt(transform.position);
		explosion.SetActive (true);
		explosion.GetComponent<ParticleSystem> ().Play();
		gameObject.SetActive (false);
		yield return new WaitForSeconds(explosion.GetComponent<ParticleSystem> ().main.duration);
		explosion.GetComponent<ParticleSystem> ().Stop();
		Destroy(gameObject);
	}

	// Use this for initialization
	void Start () {
		setTargetPosition ();
		float sign = Random.Range (0, 2) * 2 - 1; // positive or negative
		Vector3 position = new Vector3(sign * Random.Range(10.0f, 15.0f), Random.Range(-1.0f, 1.0f), sign * Random.Range(10.0f, 15.0f));
		transform.position = position;
		healthTextObject.GetComponent<TextMeshProUGUI> ().text = "Health: " + SaveManager.Instance.state.health;
		//Debug.Log ("Dragon Position: "+position);
	}

	// Update is called once per frame
	void Update () {
		distanceTextObject.GetComponent<TextMeshProUGUI> ().text = "Distance: " + Vector3.Distance(transform.position, targetPosition);
		if (dragonLife <= 0) {
			if (!playercontrol.anim.GetCurrentAnimatorStateInfo (0).IsName ("Die")) {
				playercontrol.Die ();
				StartCoroutine (DestroyDragon (3));
			}
		} else if (playercontrol.anim.GetCurrentAnimatorStateInfo (0).IsName ("Get Hit")) {
			//do nothing
		} else if (Vector3.Distance (transform.position, targetPosition) <= attackRange) { //attack
			if (!playercontrol.anim.GetCurrentAnimatorStateInfo (0).IsName ("Flame Attack")) {// check if anim finished
				playercontrol.FlameAttack ();
				if (SaveManager.Instance.state.health > 0)
					SaveManager.Instance.state.health--;
				healthTextObject.GetComponent<TextMeshProUGUI> ().text = "Health: " + SaveManager.Instance.state.health;
				SaveManager.Instance.Save ();
			}
		} else { //fly to camera
			transform.LookAt (targetPosition); // adjust to flying to camera
			transform.position = Vector3.Lerp(transform.position, targetPosition, speed);// fly towards the camera
			playercontrol.Run ();
		}
		//Debug.Log ("Dragon Position: "+transform.position);
	}


	void setTargetPosition(){
		targetPosition = new Vector3 (target.transform.position.x, target.transform.position.y, target.transform.position.z);
	}

	void OnTriggerEnter(Collider sth){
		Debug.Log ("dragon hitted in trigger enter");
		playercontrol.GetHit ();
		if (dragonLife > 0) {
			dragonLife--;
			hitnumber++;
			hittedTextObject.GetComponent<TextMeshProUGUI> ().text = "Hitted: " + hitnumber;
			Debug.Log ("Collide transform.position: "+sth.transform.position);
		}
	}

}
