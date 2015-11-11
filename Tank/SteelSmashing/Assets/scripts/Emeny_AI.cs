using UnityEngine;
using System.Collections;

public class Emeny_AI : MonoBehaviour {

	 Transform trPlayer;
	private float EturnSpeed = 3.0f;
	public float EThrust = 10.0f;
	public float EtopSpeed  = 50.0f;
	public Rigidbody Enemy;
	private bool DidHit;
	private bool backUp;
	// Use this for initialization
	void Start () {

		trPlayer = GameObject.FindGameObjectWithTag ("Player").transform;

	}
	public void BackItUp(){
		// turn reverse on
		backUp = true;

	}

	public void DoneBackUp(){
		//turn back on forward and reverse off
		DidHit = false;
		backUp = false;
		
	}

	// check to see if it hit a player
	void OnCollisionEnter(Collision col){

		if (col.gameObject.tag == "Player") {
			DidHit = true;
			Invoke ("BackItUp", .2f);
		}
	}

	// check to see if it backed out of a player
	void OnCollisionExit(Collision col){
		if (col.gameObject.tag == "Player") {
			Invoke ("DoneBackUp", 2);
		}
	}
	// Update is called once per frame
	void Update () {

		// turn to look at player
		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (trPlayer.position - transform.position), EturnSpeed);
	

		if (DidHit == false) {
			// follow player
		Enemy.AddForce (transform.forward * EThrust);
	
			if (Enemy.velocity.z <= EtopSpeed) {
				Enemy.AddForce (transform.forward * EThrust);
			} else {
				Enemy.velocity = Vector3.ClampMagnitude (Enemy.velocity, EtopSpeed);
			}
		}

		// back up enemy 
		if (backUp== true) {
			// follow player
			Enemy.AddForce (transform.forward * -EThrust);
			
			if (Enemy.velocity.z <= EtopSpeed) {
				Enemy.AddForce (transform.forward * -EThrust);
			} else {
				Enemy.velocity = Vector3.ClampMagnitude (Enemy.velocity, EtopSpeed);
			}
		}
	}
}
