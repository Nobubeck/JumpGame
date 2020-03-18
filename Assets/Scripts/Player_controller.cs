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

    
    

    //public float angleVelocity;
    float angle;
     public float upSpeed = 1.0f;

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
        Move();

        if(Input.GetButtonDown("Fire1") && JumpCount < 2 )
        {
            Jump();
        }

        if(player.transform.localEulerAngles.z > 20)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
        }


    }

    public void Jump()
    {
        rb2d.velocity = new Vector2(0, 0);
        rb2d.velocity = new Vector2(0.0f,flapVelocity);

        //rb2d.angularVelocity =new Vector2(0,angleVelocity);
        transform.rotation = Quaternion.Euler(0, 0,5);

        


         GetGroundTrigger.Ground = false;

            JumpCount++;
    
    }

    public void JumpReset()
    {
        JumpCount = 0;
    }

    public void Move()
    {
    if(player.transform.position.x < 300 * upSpeed){

            this.transform.Translate((8.0f+(1.5f * upSpeed) )* Time.deltaTime,0f,0f);
        }else{
            upSpeed += 1.2f;
        }
           
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "OutGameOver"){
            Debug.Log("Game Over");
        }
    }
    
}
