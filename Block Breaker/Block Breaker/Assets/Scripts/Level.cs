using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

    [SerializeField] int breakableBlocks; //Serialized for debugging purposes
     
    //cached reference
    SceneLoader sceneLOader;

    private void Start()
    {
        sceneLOader = FindObjectOfType<SceneLoader>(); 
    }

    public void CountBlocks()
    {
        breakableBlocks++;
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            sceneLOader.LoadNextScene();
        }
    }
}
