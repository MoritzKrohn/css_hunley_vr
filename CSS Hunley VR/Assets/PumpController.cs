
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.UnityEventHelper;
using VRTK;

public class PumpController : MonoBehaviour {


	private VRTK_InteractableObject_UnityEvents controlEvents;


	void Start () 
	{
		/*
		controlEvents = GetComponent<>();
		if (controlEvents == null)
		{
			controlEvents = gameObject.AddComponent<VRTK_InteractableObject_UnityEvents>();
		}*/
	}

	private void HandleChange(object sender, Control3DEventArgs e)
	{
		Debug.Log ("value: " + e.normalizedValue);
		BoatController.Instance.pump ();
	}

}
