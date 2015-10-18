using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {
    public int id;
    public Texture activeTex;
    public Texture inactiveTex;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public int getId()
    {
        return id;
    }

    public void setId(int someId)
    {
        id = someId;
    }

    public void setTex(bool active)
    {
        if(active)
        {
            //GetComponent<Material>().SetColor("_MainTex", Color.red);
            GetComponent<MeshRenderer>().material.SetTexture("_MainTex", activeTex);
        } else
        {
            // GetComponent<Material>().SetTexture("_MainTex", inactiveTex);
            GetComponent<MeshRenderer>().material.SetTexture("_MainTex", inactiveTex);
        }
    }

}
