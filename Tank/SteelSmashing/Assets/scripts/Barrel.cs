using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Barrel : MonoBehaviour {
	//allows the gun barrels to be switched//
	bool gunSwap;
	public GameObject Gun01;
	public GameObject Gun02;
	
	public void TankBarrelSwitch()
	{
		gunSwap = !gunSwap;
		Gun01.SetActive(!gunSwap);
		Gun02.SetActive(gunSwap);
	}

}
