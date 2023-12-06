using UnityEngine;

public class playerScript : MonoBehaviour
{
    [SerializeField] playerCollosion collision;

    public Rigidbody rb;
    public float upwardForce = 10f;
    public float sidewayForce = 500f;
    public float cooldown = 1f; // Cooldown time in seconds
    private bool canJump = true;

    [SerializeField] ColorData colorData;

    void Start()
    {
        // Find the cube in the scene (assuming it has a specific tag)
        GameObject cube = GameObject.FindGameObjectWithTag("CubeTag");

        // Set the cube's color with the loaded values from the ScriptableObject
        if (cube != null && colorData != null)
        {
            cube.GetComponent<Renderer>().material.color = colorData.cubeColor;
        }
    }

    void FixedUpdate()
    {
        #region Mobile Controller 

        MoveLeft();
        MoveRight();

        #endregion
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

        if(gameObject.transform.position.y < -15f)
        {
            collision.gameoverPanel.SetActive(true);
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    void ResetJump()
    {
        canJump = true; // Set canJump to true after cooldown
    }
    

    #region Mobile Controlls

    public void MoveLeft()
    {
        rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    public void MoveRight()
    {
        rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    #endregion


}
