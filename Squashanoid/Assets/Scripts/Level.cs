using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    int blocksCount;

    // Start is called before the first frame update
    void Start()
    {
        blocksCount = GameObject.FindGameObjectsWithTag("Block").Length;
    }

    public void OnBlockBroken()
    {
        blocksCount--;
        if (blocksCount == 0) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
