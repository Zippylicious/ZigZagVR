using UnityEngine;
using System.Collections;

public class CharacterCollisions : MonoBehaviour {
    public GameManager manager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Block b = hit.collider.GetComponent<Block>();
        b.setTex(true);
        manager.setText("" + b.getId());
        manager.setScore(b.getId());
        manager.onBlock(b);
    }

  

}
