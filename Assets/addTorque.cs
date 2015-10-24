using UnityEngine;
using System.Collections;

public class addTorque : MonoBehaviour {
	public float torque;
    public GameManager manager;
	public Rigidbody rb;
	void Start() {
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate() {
        if (!manager.getAlive())
        {
            if (rb.angularVelocity.magnitude < 3)
            {
                rb.AddTorque(0, 0, torque * -1);
            }
        }
	}
}