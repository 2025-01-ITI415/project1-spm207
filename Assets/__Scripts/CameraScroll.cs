using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    public float maxScrollSpeed = 3f;     // Maximum scroll speed
    public float accelerationTime = 60f;    // Time (in seconds) to reach maximum speed
    private float currentScrollSpeed = 0f; // Current scroll speed
    private float startTime;                // Time when scrolling started

    private void Start()
    {
        ResetScroll();
    }
    void Update()
    {
        float elapsedTime = Time.time - startTime;

        // Gradually increase the speed over time
        currentScrollSpeed = Mathf.Lerp(0f, maxScrollSpeed, Time.time / accelerationTime);

        // Move the camera downward continuously at the current speed
        transform.Translate(Vector3.down * currentScrollSpeed * Time.deltaTime);
    }

    public void ResetScroll()
    {
        currentScrollSpeed = 0f;
        startTime = Time.time;

    }

}

