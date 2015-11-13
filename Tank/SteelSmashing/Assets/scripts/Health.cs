using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public Slider healthBar;
	public static int playerHealth;
	public static int enemyHealth;
	// Use this for initialization
	void Start () {
	
		playerHealth = 100;
		enemyHealth = 100;
		healthBar.value = 100;

	}

	public void LoadScore(){
		//Application.loadedLevel ();
	}
	// Update is called once per frame
	void Update () {

	//	print ("player" + playerHealth);
	//	print ("enemy" + enemyHealth);
		healthBar.value = playerHealth;

		if (playerHealth <= 0) {
		}
		if (enemyHealth <= 0) {
		
		}
	
	}
}
