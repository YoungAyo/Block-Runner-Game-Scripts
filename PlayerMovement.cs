
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;
    public float fowardForce = 2000f;
    public float sidewayForce = 500f;
    public float acceleration = 1f;
    public bool playerOnGround = true;
    

    void Start()
    {

        //rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //foward force
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);


        //sideways movement

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);


        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);


        }

        if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 30f);

        }

        
        if(rb.position.y < -5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if(Input.GetButtonDown("Jump") && playerOnGround) 
        {
            rb.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
            playerOnGround = false;
        }


    }

    private void OnCollisionEnter(Collision collisionInfo)
    {

        if(collisionInfo.gameObject.name == "Ground" )
        {
            playerOnGround = true;
        }

        if(collisionInfo.gameObject.name == "Cube" )
        {
            playerOnGround = true;
        }

    }

    
}




