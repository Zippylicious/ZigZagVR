using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
public class GameManager : MonoBehaviour {

    CardboardHead head = null;
    public getText scoreText;
    private int score;
    public PathGenerator pathPrefab;
    public Autowalk walker;
    private PathGenerator pathInstance;

    private Block currentBlock;
    private Block previousBlock;



    public MainCamera mainCamera;
    // Use this for initialization
    void Start () {
        head = Camera.main.GetComponent<StereoController>().Head;
        BeginGame();
   
    }
	
	// Update is called once per frame
	void Update () {
       // score.setText("10000");
        if (head.transform.position.y <= 6.08)
        {
            RestartGame();
           
        }

        walker.setSpeed((float)(Math.Min(3 + .1*score, 8.0)));

    }

    public void setScore(int someScore)
    {
        score = someScore;
    }

    public void setText(string someText)
    {
        scoreText.setText(someText);
    }

    public void onBlock(Block b)
    {
        previousBlock = currentBlock;

        
        currentBlock = b;
        if(previousBlock != currentBlock)
        {
            previousBlock.setTex(false);
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
