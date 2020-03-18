using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class StageGenerator : MonoBehaviour
{



    public GameObject player;
    public GameObject StagePrefab;
    public int generateCount = 0;

    // Start is called before the first frame update
    void Start()
    {
         //int seed = Environment.TickCount;
    }

    // Update is called once per frame
    void Update()
    {
    if(player.transform.position.x > (8 * (generateCount + 1))) {
        Debug.Log(generateCount);
        BlockGenerate();
        generateCount++;    
    }

    }

public void BlockGenerate()
{

     System.Random rnd = new System.Random();


    GameObject stage = Instantiate(
        StagePrefab,
        new Vector3(40.0f + player.transform.position.x +  rnd.Next(5,22),-6.0f + rnd.Next(0,2),0.0f),
        Quaternion.identity
    );
}

}
