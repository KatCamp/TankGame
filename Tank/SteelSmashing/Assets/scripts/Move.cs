using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Move : MonoBehaviour {

	public float thrust = 90.0f; 
	public float topSpeed = 50.0f;
	public float rotateSpeed = 80.0f; 
	public bool GasIsDown { set; get;}
	public bool ReverseIsDown { set; get;}
	public bool RightIsDown { set; get;}
	public bool LeftIsDown { set; get;}
	public Rigidbody Car;
	// Use this for initialization 
	void Start () { 
		Car = GetComponent<Rigidbody> ();

	} 

	// Update is called once per frame 
	public void Gas(){

		Car.AddForce (transform.forward * thrust);

		if (Car.velocity.z <= topSpeed) {
			Car.AddForce (transform.forward * thrust);
		} else {
			Car.velocity = Vector3.ClampMagnitude(Car.velocity, topSpeed);
		}
		
	}

	public void Reverse(){
		Car.AddForce (transform.forward * -thrust);
		if (Car.velocity.z >= -topSpeed) {
			Car.AddForce (transform.forward * -thrust);
		} else {
			Car.velocity = Vector3.ClampMagnitude(Car.velocity, -topSpeed);
		}
		
	}
	public void TurnRight(){

	//	if (Car.velocity.z >= 0) {
			transform.Rotate (0.0f, rotateSpeed * Time.deltaTime, 0.0f);
	//	} else {
	//		transform.Rotate (0.0f, -rotateSpeed * Time.deltaTime, 0.0f);
	//	}
	}

	public void TurnLeft(){
		
	//	if (Car.velocity.z <= 0) {
			transform.Rotate (0.0f, -rotateSpeed * Time.deltaTime, 0.0f);
		//} else {
	//		transform.Rotate (0.0f, rotateSpeed * Time.deltaTime, 0.0f);
	//	}
	}


	void Update () { 

		//move forward
		if (GasIsDown) {
			Gas();
		}

		if (RightIsDown) {
			TurnRight();
		}

		if (LeftIsDown) {
			TurnLeft();
		}

		transform.Rotate(0, Input.acceleration.y * rotateSpeed * Time.deltaTime, 0);
	

//		// car backing up turn
//		if (ReverseIsDown && RightIsDown) {
//
//			transform.Rotate( 0.0f, -rotateSpeed * Time.deltaTime, 0.0f);
//
//		}else if (RightIsDown) {
//			// car turn normal
//				TurnRight ();
//
//				//print (Car.velocity.z);
//			}
//
//		//car backing up turn
//		if (ReverseIsDown && LeftIsDown) {
//
//			transform.Rotate( 0.0f, rotateSpeed * Time.deltaTime, 0.0f);
//
//		} else if(LeftIsDown){
//			//car turn normal
//				TurnLeft();
//			}

		//backing up
		if (ReverseIsDown) {
			Reverse();
			//print (Car.velocity.z);

		}


	} 
} 
