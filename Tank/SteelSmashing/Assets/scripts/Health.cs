using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public static int playerHealth;
	public static int enemyHealth;
	// Use this for initialization
	void Start () {
	
		playerHealth = 100;
		enemyHealth = 100;
	}

	public void loadMenue(){
		//Application.loadedLevel ();
	}
	// Update is called once per frame
	void Update () {

	//	print ("player" + playerHealth);
	//	print ("enemy" + enemyHealth);

		if (playerHealth <= 0) {
		}
		if (enemyHealth <= 0) {
		
		}
	
	}
}
