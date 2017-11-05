using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	

	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("HIT");
		BoatController.Instance.pump ();
	}
}
