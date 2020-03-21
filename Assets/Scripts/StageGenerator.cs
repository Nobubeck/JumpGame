using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class StageGenerator : MonoBehaviour
{



    public GameObject player;
    public GameObject[] StagePrefabs;
    public int generateCount = 0;
    public int Stageindex ;

    // Start is called before the first frame update
    void Start()
    {
           Stageindex = 0;
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

    GameObject SampleStage()
    {
         Stageindex = UnityEngine.Random.Range(0,StagePrefabs.Length);
        return StagePrefabs[Stageindex];
    }

    Vector3 GetInstantiatePosition(){
         System.Random rnd = new System.Random();
if(Stageindex == 0){

    return new Vector3(40.0f + player.transform.position.x +  rnd.Next(5,22),-6.0f + rnd.Next(0,2),0.0f);
}else if(Stageindex == 1){
    return new Vector3(40.0f + player.transform.position.x +  22.0f,-6.0f + rnd.Next(0,2),0.0f);
    Debug.Log(Stageindex);
}else{
    return new Vector3(40.0f + player.transform.position.x +  rnd.Next(5,22),-6.0f + rnd.Next(0,2),0.0f);
}
    
    }

public void BlockGenerate()
{

    


    GameObject stage = (GameObject)Instantiate(
        SampleStage(),
       GetInstantiatePosition(),
        Quaternion.identity
    );
}

}
