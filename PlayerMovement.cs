using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform groundCheckTransform;
    public Rigidbody rb;
    private bool jumpKeyWasPressed;
    public float forwardForce = 6000f;
    public float sidewaysForce = 120f;
    private bool movingLeft;
    private bool movingRight;


    // Start is called before the first frame update
    void Start()
    {
        
        //rb.AddForce(0, 200, 500);
        //rb.useGravity = false;
        //Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
        }
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            movingRight = true;
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            movingLeft = true;
        }
    }

    //use fixedupdate for physics
    void FixedUpdate()
    {

        if (movingRight)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            movingRight = false;
        }
        if (movingLeft)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            movingLeft = false;
        }
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (rb.position.y < -1f)
        {

            FindObjectOfType<GameManager>().EndGame();
        }
  
        if (Physics.OverlapSphere(groundCheckTransform.position,0.1f).Length == 1)
        {
            return;
        }
        if (jumpKeyWasPressed == true)
        {
            FindObjectOfType<AudioManager>().PlaySound("Jumping");
            rb.AddForce(Vector3.up * 8 , ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }

        

        
    }


}
