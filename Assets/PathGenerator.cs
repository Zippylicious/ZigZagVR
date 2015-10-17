using UnityEngine;
using System.Collections;

public class PathGenerator : MonoBehaviour {
    public int sizeX, sizeZ;

    public Block blockPrefab;

    private Block[,] blocks;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Generate()
    {
        blocks = new Block[sizeX, sizeZ];
        for (int x = 0; x < sizeX; x++)
        {
            for (int z = 0; z < sizeZ; z++)
            {
                CreateBlock(x, z);
            }
        }
    }

    private void CreateBlock(int x, int z)
    {
        Block newBlock = Instantiate(blockPrefab) as Block;
        blocks[x, z] = newBlock;
        newBlock.name = "Block " + x + ", " + z;
        newBlock.transform.parent = transform;
        newBlock.transform.localPosition = new Vector3(x - sizeX * 0.5f + 0.5f, 0f, z - sizeZ * 0.5f + 0.5f);
    }








}
