using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    Rigidbody2D rb2d;
    public GameObject player;
    
        public GroundTrigger GetGroundTrigger;
    public int JumpCount = 0;

    public float flapVelocity;
    public float relativeVelocityX;
    float angle;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ApplyAngle();
        Move();

        if(Input.GetButtonDown("Fire1") && JumpCount < 2 )
        {
            Jump();
        }


    }

    public void Jump()
    {
        rb2d.velocity = new Vector2(0, 0);
        rb2d.velocity = new Vector2(0.0f,flapVelocity);

         GetGroundTrigger.Ground = false;

            JumpCount++;
    
    }

    public void JumpReset()
    {
        JumpCount = 0;
    }

    public void Move()
    {
           this.transform.Translate(0.05f,0f,0f);
    }

    void ApplyAngle()
    {
    }
}
