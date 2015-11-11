using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {

	public float maxTime = 7;
	public float minTime = 4;
	private float time;
	private float spawnTime;
	public Rigidbody bullet;
	public float speed = 20;
	// Use this for initialization
	void Start () {
		SetRandomTime ();
		time = minTime;
	}
	

	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		
		//check for righ time to spawn 
		if (time >= spawnTime) {
			Spawn();
			SetRandomTime();
		}

	}

	void Spawn (){
		time = 0;
		Rigidbody instantiatedProjectile = Instantiate(bullet,transform.position,transform.rotation)as Rigidbody;
		instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0,speed));
	}
	
	void SetRandomTime(){
		spawnTime = Random.Range(minTime, maxTime);
	}
}
