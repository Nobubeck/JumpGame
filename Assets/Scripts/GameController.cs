using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject player;
    public Text stateText;

    public Text scoreText;



    // Start is called before the first frame update
    void Start()
    {
        Ready();
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y < -20)
        {
            stateText.gameObject.SetActive(true);
            stateText.text = "Game Over";
            Destroy(player);
        }else{
            stateText.gameObject.SetActive(false);
            stateText.text = "";
        }

        scoreText.text = "Score :  " + (int)player.transform.position.x + "m";

      

        
    }

    void Ready()
    {
        scoreText.text = "Score : " + 0;
        stateText.gameObject.SetActive(true);
        stateText.text = "Ready";
    }


    
}
