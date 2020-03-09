using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject player;
    public Text stateText;



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
    }

    void Ready()
    {
        
        stateText.gameObject.SetActive(true);
        stateText.text = "Ready";
    }

    
}
