using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tank_Body : MonoBehaviour {
	//allows the gun bodies to be switched//
	bool bodySwap;
	public GameObject body01;
	public GameObject body02;
	
	public void TankBodySwitch()
	{
		bodySwap = !bodySwap;
		body01.SetActive(!bodySwap);
		body02.SetActive(bodySwap);
	}

}
