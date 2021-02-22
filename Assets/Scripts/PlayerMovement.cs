using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 500f;
    private bool dkeyPressed;
    private bool akeyPressed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            akeyPressed = true;
        }
        if (Input.GetKeyDown("d"))
        {
            dkeyPressed = true;
        }
    }
    

    void FixedUpdate()
    {
        // Adds a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (dkeyPressed)
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            dkeyPressed = false;
        }
        if (akeyPressed)
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            akeyPressed = false;
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}

