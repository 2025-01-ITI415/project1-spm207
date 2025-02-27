using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    public float maxScrollSpeed = 10f;     // Maximum scroll speed
    public float accelerationTime = 30f;    // Time (in seconds) to reach maximum speed
    private float currentScrollSpeed = 0f; // Current scroll speed

    void Update()
    {
        // Gradually increase the speed over time
        currentScrollSpeed = Mathf.Lerp(0f, maxScrollSpeed, Time.time / accelerationTime);

        // Move the camera downward continuously at the current speed
        transform.Translate(Vector3.down * currentScrollSpeed * Time.deltaTime);
    }

    //    public float scrollSpeed = 1f;

    //    void Update()
    //    {
    // Move the camera downward continuously
    //        transform.Translate(Vector3.down * scrollSpeed * Time.deltaTime);
    //    }
}

