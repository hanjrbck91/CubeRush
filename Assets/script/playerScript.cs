using UnityEngine;

public class playerScript : MonoBehaviour
{
    [SerializeField] playerCollosion collision;

    public Rigidbody rb;
    public float upwardForce = 10f;
    public float sidewayForce = 500f;
    public float tiltSensitivity = 10f; // Adjust this value based on the desired sensitivity

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

        // Add sideway force based on input
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.AddForce(sidewayForce * horizontalInput * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        // Add sideway force based on tilt input
        float tiltInput = Input.acceleration.x * tiltSensitivity;
        rb.AddForce(sidewayForce * tiltInput * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        if (gameObject.transform.position.y < -15f)
        {
            gameObject.SetActive(false);
            collision.gameoverPanel.SetActive(true);
            FindObjectOfType<GameManager>().EndGame();
        }
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