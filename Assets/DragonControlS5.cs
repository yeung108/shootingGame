using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
using TMPro;
using DigitalRuby.PyroParticles;

public class DragonControlS5 : MonoBehaviour {

	public GameObject healthTextObject;
	public GameObject distanceTextObject;
	public GameObject hittedTextObject;
	public playerControl playercontrol;
	public GameObject target;
	public GameObject explosion;
	public GameObject flamethrower;
	private Vector3 targetPosition;
	private float speed = .01f;
	private float dragonLife = 100f;
	private float maxDragonLife = 100f;
	private float attackRange = 6.0f;
	private int bulletPower = 2;
	private int knifePower = 1;
	public UnityEngine.UI.Image healthbar;
	private float attackTime;

	IEnumerator DestroyDragon(float time)
	{
		yield return new WaitForSeconds(time);
		explosion.PositionAt(transform.position);
		explosion.SetActive (true);
		//Instantiate (explosion, transform.position, transform.rotation);
		explosion.GetComponent<ParticleSystem> ().Play();
		gameObject.SetActive (false);
		yield return new WaitForSeconds(explosion.GetComponent<ParticleSystem> ().main.duration);
		explosion.GetComponent<ParticleSystem> ().Stop();
		Destroy(gameObject);
	}

	IEnumerator fireAttack(float waitingtime)
	{
		yield return new WaitForSeconds(waitingtime);
		float delayForXPosition = playercontrol.anim.GetCurrentAnimatorStateInfo (0).normalizedTime * 100 - 30;
		Vector3 flamePosition = Vector3.zero;
		flamePosition = new Vector3 (transform.position.x, transform.position.y + 1.4f, transform.position.z);
		Debug.Log(transform.position);
		Debug.Log (flamePosition);
		Debug.Log ("Time: " + Time.deltaTime);
		Destroy(Instantiate (flamethrower, flamePosition, transform.rotation), 2f);
		flamethrower.GetComponent<FireBaseScript>().transform.LookAt (targetPosition);
	}

	// Use this for initialization
	void Start () {
		setTargetPosition ();
		float sign = Random.Range (0, 2) * 2 - 1; // positive or negative
		Vector3 position = new Vector3(sign * Random.Range(10.0f, 50.0f), Random.Range(-2.0f, 2.0f), sign * Random.Range(10.0f, 50.0f));
		transform.position = position;
		healthTextObject.GetComponent<TextMeshProUGUI> ().text = "Health: " + SaveManager.Instance.state.health;
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
			if (!playercontrol.anim.GetCurrentAnimatorStateInfo (0).IsName ("Scream")) {// check if anim finished
				playercontrol.Scream ();
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
			if (sth.tag == "bullet") {
				dragonLife -= bulletPower;
			} else {
				dragonLife -= knifePower;
			}
			Debug.Log ("Collide transform.position: "+sth.transform.position);
			healthbar.fillAmount = dragonLife / maxDragonLife;
		}
	}

}
