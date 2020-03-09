using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTrigger : MonoBehaviour
{
      public GameObject Player;
    public bool Ground = true;
 
    void Update()
    {
        
    }
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player.GetComponent<Player_controller>().JumpReset();
        Ground = true;
    }
 
    /*private void OnTriggerExit2D(Collider2D collision)
    {
        Ground = false;
    }*/
}
