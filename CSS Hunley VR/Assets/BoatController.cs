using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoatController : MonoBehaviour {

	public static BoatController Instance { get { return _instance; } }

	public Transform Ocean;
	public float maxDepth = 2f;
	public float maxSpeed = 0.05f;
	public float pumpRate;


	public float waterRate = 0;
	public float currentWaterLevel = 0;

	private static BoatController _instance;



	// Use this for initialization
	void Start () {
		_instance = this;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (currentWaterLevel < 1f)
		{
			currentWaterLevel += waterRate * Time.deltaTime * 0.5f;
		}
		//if (Mathf.Abs (transform.position.y - maxDepth) < 0.1f) {
			sink ();
		// }
	}

	private void sink()
	{
		//float waterRatio = currentWaterLevel / 1f;
		//float depthRatio = Ocean.position.y / maxDepth;
		//float difference = waterRatio - depthRatio;
		float targetDepth = maxDepth * currentWaterLevel;
		//Debug.Log ("waterRatio / depthRatio = difference = " + waterRatio + " / " + depthRatio + " = " + difference);
		// Debug.Log ("speed = " + Time.deltaTime * difference * maxSpeed);
		Debug.Log("deoth " + targetDepth);
		float yNew = Mathf.Lerp (Ocean.position.y, targetDepth, Time.deltaTime * maxSpeed);
		Debug.Log ("yNew = " + yNew);
		//Debug.Log ("yNew = " + yNew);
		Ocean.position = new Vector3 (Ocean.position.x, yNew, Ocean.position.z);
		//Debug.Log ("Pos = " + Ocean.position);
	}

	public void setWaterRate(float r)
	{
		//Debug.Log ("New water rate = " + r);
		waterRate = r;
	}

	public void pump()
	{
		currentWaterLevel = (currentWaterLevel - pumpRate <= 0f) ? 0.0f : currentWaterLevel - pumpRate;
	}
}
