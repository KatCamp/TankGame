using UnityEngine;
using System.Collections;

public class TankCollision : MonoBehaviour {


	public Vector3 velocityhiting;
	private float hitDegree;
	private float carVelocity;
	private float otherVelocity;
	// Use this for initialization
	void Start () {
	
	}



	void OnCollisionEnter(Collision col){
	
		//Damage to Enemy
		if (col.gameObject.layer == 8) {
			//print (carVelocity);

			carVelocity = velocityhiting.magnitude;
			otherVelocity = col.gameObject.GetComponent<TankCollision>().velocityhiting.magnitude;
		
			hitDegree = Vector3.Dot(col.transform.forward.normalized ,transform.forward.normalized);
		//	print("PlayerVelocity" + carVelocity);
			// head on collision
			if (hitDegree >= -1 && hitDegree <= -.75f){
				if(carVelocity > 1 && carVelocity <= 10){
					Health.enemyHealth = Health.enemyHealth - 5;
				}
				if(carVelocity > 10){
					Health.enemyHealth = Health.enemyHealth - 10;
				}


			}

			if (hitDegree >= -.75f && hitDegree <= .75f){
				if(carVelocity > 1 && carVelocity <= 10){
					Health.enemyHealth = Health.enemyHealth - 5;
				}
				if(carVelocity > 10){
					Health.enemyHealth = Health.enemyHealth - 10;
				}
				
				
			}
			//other collision not parallel
			if(hitDegree >.75f && hitDegree < 1){
				if(carVelocity > 5 && carVelocity <= 15){
					Health.enemyHealth = Health.enemyHealth - 5;
				}
				if(carVelocity > 15){
					Health.enemyHealth = Health.enemyHealth - 10;
				}
			
			}
		
		}


		//Damage player
		if (col.gameObject.tag == "Player") {


			carVelocity = velocityhiting.magnitude;
			otherVelocity = col.gameObject.GetComponent<TankCollision>().velocityhiting.magnitude;

				

			hitDegree = Vector3.Dot(col.transform.forward ,transform.forward);
		//	print("enemyVelocity" + carVelocity);
			// head on collision
			if (hitDegree >= -1 && hitDegree <= -.75f){

				if(carVelocity > 5 && carVelocity <= 10){
					Health.playerHealth = Health.playerHealth - 5;
						
				}
				if(carVelocity > 10){
					Health.playerHealth = Health.playerHealth - 10;

				}
				
				
			}
			if (hitDegree >= -.75 && hitDegree <= .75f){
				
				if(carVelocity > 5 && carVelocity <= 15){
					Health.playerHealth = Health.playerHealth - 5;
					
				}
				if(carVelocity > 15){
					Health.playerHealth = Health.playerHealth - 10;
					
				}
				
				
			}
			//other collision not parallel
			if(hitDegree >.75f && hitDegree < 1){

				if(carVelocity > 1 && carVelocity <= 10){
				Health.playerHealth = Health.playerHealth - 5;
				}
				if(carVelocity > 10){
					Health.playerHealth = Health.playerHealth - 10;
				}
				
			}
			
		}
		if (this.gameObject.layer == 8) {
			if (col.gameObject.tag == "Pbullet") {
				Health.playerHealth = Health.playerHealth - 3;

			}
		}
		if (this.gameObject.tag == "Player") {
			if (col.gameObject.tag == "Ebullet") {
				Health.playerHealth = Health.playerHealth - 3;
			
			}
		}

	
	}
	
	// Update is called once per frame
	void Update () {
		velocityhiting = GetComponent<Rigidbody> ().velocity;
	}
}
