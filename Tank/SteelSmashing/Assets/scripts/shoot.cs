using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

	public Rigidbody bullet;
	public float speed = 20;
	
	// Update is called once per frame

	public void Fire(){
		Rigidbody instantiatedProjectile = Instantiate(bullet,transform.position,transform.rotation)as Rigidbody;
		instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0,speed));
	}


	void Update ()
	{

}
}
