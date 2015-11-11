using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Radar : MonoBehaviour {

	public GameObject[] trackedObjects;
	List<GameObject> radarObjects;
	public GameObject radarPrefab;
	List<GameObject> borderObjects;
	public float switchDistance;
	public Transform helpTransform;

	// Use this for initialization
	void Start () {
		CreateRadarObjects ();
	}

	void CreateRadarObjects(){
	
		radarObjects = new List<GameObject> ();
		borderObjects = new List<GameObject> ();
		foreach (GameObject o in trackedObjects) {
			GameObject k = Instantiate(radarPrefab,o.transform.position, Quaternion.identity) as GameObject;
			radarObjects.Add(k);
			k.transform.parent = o.transform;
			GameObject j = Instantiate(radarPrefab,o.transform.position, Quaternion.identity) as GameObject;
			borderObjects.Add(j);
			j.transform.parent = o.transform;
		}
	
	
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < radarObjects.Count; i++) {
			// switch to border objects 
			if(Vector3.Distance(radarObjects[i].transform.position, transform.position)> switchDistance){

				helpTransform.LookAt(radarObjects[i].transform);
				borderObjects[i].transform.position = transform.position + switchDistance*helpTransform.forward;
				borderObjects[i].layer = LayerMask.NameToLayer("Radar");
				radarObjects[i].layer = LayerMask.NameToLayer("Invisible");

			}else{
				radarObjects[i].layer = LayerMask.NameToLayer("Radar");
				borderObjects[i].layer = LayerMask.NameToLayer("Invisible");
				//switch to radar objects
			}
		}
			
	}
}
