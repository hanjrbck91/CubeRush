using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public Rigidbody rb;
    public float upwardForce = 10f;
    public float sidewayForce = 500f;
    public float cooldown = 1f; // Cooldown time in seconds
    private bool canJump = true;

    void FixedUpdate()
    {
        // Check if the cooldown has passed and the space key is pressed
        if (canJump && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(0f, upwardForce * Time.deltaTime, 0f, ForceMode.Impulse);
            canJump = false; // Set canJump to false to initiate cooldown
            Invoke("ResetJump", cooldown);
        }

        // Add sideway force based on input
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.AddForce(sidewayForce * horizontalInput * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    void ResetJump()
    {
        canJump = true; // Set canJump to true after cooldown
    }
}
