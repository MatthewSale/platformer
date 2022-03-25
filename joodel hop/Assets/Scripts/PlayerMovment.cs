using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    Rigidbody rb;
    float junp = 400;

    bool jump = false;
    bool grounded = true;
    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            if (grounded == true)
            {
                if (jump == false)
                {
                    rb.AddForce(transform.up * junp);
                    jump = true;
                    grounded = false;
                }
            }
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-transform.right * 25);
        }

        if(Input.GetKey("d"))
        {
            rb.AddForce(transform.right * 25);
        }

        if (Input.GetKeyUp("w"))
        {
            jump = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Ground"))
        {
            grounded = true;
        }
    }
}
