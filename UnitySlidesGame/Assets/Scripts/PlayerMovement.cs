using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;     // adding a rigid body rb
    public float ForwardForce = 2000f;
    public float SidewaysForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,ForwardForce*Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(SidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-SidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(rb.position.y <-1f){
           FindObjectOfType<GameManager>().EndGame();
        }  
        if(rb.position.z > 70f)
        {
            FindObjectOfType<GameManager>().Credit();

        }


    }
}
