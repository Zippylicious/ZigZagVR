using UnityEngine;
using System.Collections;

public class PathGenerator : MonoBehaviour {
    public int numBlocks;
    public Block blockPrefab;
    public int longestPath;
    public int shortestPath;

    private Block[] blocks;
    private int pathCounter;
    private int pathLength;
    //Direction: 0 = left, 1 = forward, 2 = right
    private int direction;
    private int currentX;
    private int currentZ;






    // Use this for initialization
    void Start () {
        direction = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Generate()
    {
        blocks = new Block[numBlocks];
        for (int i = 0; i < numBlocks; i++)
        {

            if (i < 8)
            {
                currentX += 2;
                CreateBlock(currentX, currentZ, i);
            }
            else
            {


                //IF REACHED END OF PATH
                if (pathLength == 0)
                {
                    //CHOOSE NEW DIRECTION
                    //IF DIRECTION IS RIGHT OR LEFT, DIRECTION IS ALWAYS FORWARD
                    if (direction == 0 || direction == 2)
                    {
                        direction = 1;
                    }
                    else
                    {
                        //IF DIRECTION IS FORWARD, RANDOMLY CHOOSE RIGHT OR LEFT
                        if (Random.Range(0, 2) == 0)
                        {
                            direction = 0;
                        }
                        else
                        {
                            direction = 2;
                        }
                    }


                    //CHOOSE NEW PATH LENGTH
                    pathLength = Random.Range(shortestPath, longestPath + 1);

                }


                if (direction == 1)
                {
                    currentX += 2;
                }
                else if (direction == 0)
                {
                    currentZ += 2;
                }
                else
                {
                    currentZ -= 2;
                }

                CreateBlock(currentX, currentZ, i);
                pathLength--;
            }
        }
    }

    private void CreateBlock(int x, int z, int i)
    {
        Block newBlock = Instantiate(blockPrefab) as Block;
        newBlock.setId(i);
        blocks[i] = newBlock;
        newBlock.name = "Block " + x + ", " + z;
        newBlock.transform.parent = transform;
        newBlock.transform.localPosition = new Vector3(x, 0, z);
    }








}
