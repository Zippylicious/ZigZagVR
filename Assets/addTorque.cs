using UnityEngine;
using System.Collections;

public class addTorque : MonoBehaviour {
	public float torque;
	public Rigidbody rb;
	void Start() {
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate() {
		if(rb.angularVelocity.magnitude < 1.5){
			rb.AddTorque (transform.right * torque);
		}
	}
}