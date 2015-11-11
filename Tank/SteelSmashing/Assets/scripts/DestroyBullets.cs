using UnityEngine;
using System.Collections;

public class DestroyBullets : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public void OnCollisionEnter(Collision col){
	
		Destroy (this.gameObject);

		if (col.gameObject.layer == 8) {
			Destroy(col.gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
