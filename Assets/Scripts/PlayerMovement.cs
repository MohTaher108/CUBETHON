using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // Reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update() is called once per frame
    // We changed it to FixedUpdate() because it works better than Update() for physics
    void FixedUpdate()
    {
        // Add a force of 2000 on the z-axis every frame, 
        // If we add a force every frame then the amount of times the force is applied changes if the fps changes, so multiply by 1 / fps which is called Time.deltaTime
        // rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Move right
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Move left
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        if(Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }
        
        // Have we fallen under the map? If so then end the game
        if(rb.position.y < -1f) 
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
