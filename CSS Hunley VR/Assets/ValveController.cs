
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK.UnityEventHelper;
using VRTK;

public class ValveController : MonoBehaviour {


	private VRTK_Control_UnityEvents controlEvents;


	void Start () 
	{
		Invoke ("Initialize", 0.1f);
	}

	private void Initialize()
	{
		controlEvents = GetComponent<VRTK_Control_UnityEvents>();
		if (controlEvents == null)
		{
			controlEvents = gameObject.AddComponent<VRTK_Control_UnityEvents>();
		}
		controlEvents.OnValueChanged.AddListener(HandleChange);
	}
	
	private void HandleChange(object sender, Control3DEventArgs e)
	{
		Debug.Log ("CHANGE " +  e.normalizedValue);
		BoatController.Instance.setWaterRate(e.normalizedValue / 1000);
	}

}
