using UnityEngine;
using System.Collections;

public class PhysTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter () {
		Debug.Log ("Collided!");
		gameObject.GetComponent<ConstantForce>().enabled = true;
	}
}
