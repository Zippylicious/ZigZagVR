using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class getText : MonoBehaviour {

    Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void setText(string someText)
    {
        text.text = someText;
    }
}
