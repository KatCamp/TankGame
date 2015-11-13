using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tank_Wheels : MonoBehaviour {

	//allows the gun barrels to be switched//
	bool wheelSwap;
	public GameObject wheel01;
	public GameObject wheel02;
	
	public void TankWheelSwitch()
	{
		wheelSwap = !wheelSwap;
		wheel01.SetActive(!wheelSwap);
		wheel02.SetActive(wheelSwap);
	}
}
