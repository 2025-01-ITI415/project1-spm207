using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;    // Movement speed
    public float jumpForce = 10f;   // Jump force
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody component
    }

    void Update()
    {
        // Handle horizontal movement
        float moveHorizontal = 0f;

        if (Input.GetKey(KeyCode.A))  // Move left
        {
            moveHorizontal = -1f;
        }
        if (Input.GetKey(KeyCode.D))  // Move right
        {
            moveHorizontal = 1f;
        }

        // Move the player left or right
        rb.velocity = new Vector3(moveHorizontal * moveSpeed, rb.velocity.y, 0f);

        // Handle jumping
        if (Input.GetKey(KeyCode.W) && Mathf.Abs(rb.velocity.y) < 0.1f) // Check if grounded before jumping
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z); // Apply jump force directly to y-velocity
        }

    }
    // public Camera mainCamera;
    // public float bottomThreshold = 0.1f;

    // void Update()
    // {
    // Check if player is below the camera's view
    //     Vector3 viewportPosition = mainCamera.WorldToViewportPoint(transform.position);
    //     if (viewportPosition.y < bottomThreshold)
    //     {
    // Game over or reset logic
    //         Debug.Log("Player fell behind!");
    //     }
    //    }
    // Start is called before the first frame update
    //    void Start()
    //    {

    //    }

}
