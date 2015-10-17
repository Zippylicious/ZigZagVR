using UnityEngine;
using System.Collections;

public class Floor : MonoBehaviour {
    public GameManager manager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collision collision)
    {
        manager.RestartGame();
        

    }
}
