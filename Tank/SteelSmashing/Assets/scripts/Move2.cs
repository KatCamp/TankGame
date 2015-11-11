using UnityEngine;
using System.Collections;

public class Move2 : MonoBehaviour {


	public float thrust = 90.0f; 
	public float topSpeed = 50.0f;
	public float rotateSpeed = 80.0f; 
	public Rigidbody Car;
	private bool GasPressed;
	private bool ReversePressed;
	private bool RightPressed;
	private bool LeftPressed;

	// Use this for initialization
	void Start () {
		Car = GetComponent<Rigidbody> ();
	}

	public void Gas(){

		if (GasPressed == false) {
			GasPressed = true;
			
		}	else if (GasPressed == true) {
			GasPressed = false;
		}
	
		
	}
	
	public void Reverse(){

		if (ReversePressed == false) {
			ReversePressed = true;
			
		}	else if (ReversePressed == true) {
			ReversePressed = false;
		}
		
	}
	public void TurnRight(){

		if (RightPressed == false) {
			RightPressed = true;

		}	else if (RightPressed == true) {
			RightPressed = false;
		}

	}
	
	public void TurnLeft(){
		
		if (LeftPressed == false) {
			LeftPressed = true;
			
		}	else if (LeftPressed == true) {
			LeftPressed = false;
		}

	}
	

	// Update is called once per frame
	void Update () {
		if (GasPressed) {

			if (Car.velocity.z <= topSpeed) {
				Car.AddForce (transform.forward * thrust);
			} else {
				Car.velocity = Vector3.ClampMagnitude(Car.velocity, topSpeed);
			}
		}

		/// Right Turns///////////////////////////////
		if(RightPressed) {
			// car turn normal
			transform.Rotate( 0.0f, rotateSpeed * Time.deltaTime, 0.0f);
			
			//print (Car.velocity.z);
		}
		if (GasPressed && RightPressed) {
			
			transform.Rotate( 0.0f, rotateSpeed * Time.deltaTime, 0.0f);
			
		}
		// car backing up turn
		if (ReversePressed && RightPressed) {
			
			transform.Rotate (0.0f, -rotateSpeed * Time.deltaTime, 0.0f);
			
		} 

		//Left Truns///////////////////////////////
		if(LeftPressed){
			//car turn normal
			transform.Rotate( 0.0f, -rotateSpeed * Time.deltaTime, 0.0f);
		}
		if (GasPressed && LeftPressed) {
			
			transform.Rotate( 0.0f, -rotateSpeed * Time.deltaTime, 0.0f);
			
		} 
		if (ReversePressed && LeftPressed) {
			
			transform.Rotate( 0.0f, rotateSpeed * Time.deltaTime, 0.0f);
			
		} 
		
		//backing up
		if (ReversePressed) {

			if (Car.velocity.z >= -topSpeed) {
				Car.AddForce (transform.forward * -thrust);

			} else {
				Car.velocity = Vector3.ClampMagnitude(Car.velocity, -topSpeed);
			}
			//print (Car.velocity.z);
			
		}


	}
}
