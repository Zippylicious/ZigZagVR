using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    CardboardHead head = null;
    public PathGenerator pathPrefab;
    private PathGenerator pathInstance;
    public MainCamera mainCamera;
    // Use this for initialization
    void Start () {
        head = Camera.main.GetComponent<StereoController>().Head;
        BeginGame();
    }
	
	// Update is called once per frame
	void Update () {

        if(head.transform.position.y <= 6.08)
        {
            RestartGame();
           
        }
       

    }

    private void BeginGame() {
        pathInstance = Instantiate(pathPrefab) as PathGenerator;
        pathInstance.Generate();
    }

    public void RestartGame() {
        Destroy(pathInstance.gameObject);
        BeginGame();
        mainCamera.Reset();

    }

}
