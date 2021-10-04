using UnityEngine;

public class GenerateBlocks : MonoBehaviour
{

    public Transform[] blocks;
    public GameObject blockPrefab;
    private int prevSec;
    // Update is called once per frame
    

    public void spawnBlocks(int sec)
    {
        int randomIndex = Random.Range(0, blocks.Length);
        if (prevSec == sec)
        {
            return;
        }else
        {
            prevSec = sec;
        }

        for (int i = 0; i < blocks.Length; i++)
        {
            if (randomIndex == i)
            {
                Instantiate(blockPrefab, blocks[i].position, Quaternion.identity);
            }
        }
    }
}
