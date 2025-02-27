using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;    // Movement speed
    public float jumpForce = 10f;   // Jump force
    private Rigidbody rb;
    private Camera mainCamera;
    public Canvas gameOverCanvas; // Reference to the Game Over Canvas
    private bool isGameOver = false;
    
    private bool IsVisibleToCamera()
    {
        Vector3 viewportPosition = mainCamera.WorldToViewportPoint(transform.position);
        return viewportPosition.x > 0 && viewportPosition.x < 1 && viewportPosition.y > 0 && viewportPosition.y < 1;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Get the Rigidbody component
        mainCamera = Camera.main; // Get the main camera

    }

    void Update()
    {
        if (isGameOver)
            return;

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

        if (!IsVisibleToCamera())

            GameOver();
    }
        
        private void GameOver()
    {
            isGameOver = true;
            Debug.Log("Game Over! Player out of camera view.");
            gameOverCanvas.gameObject.SetActive(true);
            // Disable player movement here
            this.enabled = false;
    }

}
