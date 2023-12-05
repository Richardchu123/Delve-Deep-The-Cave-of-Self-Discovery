using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform2D : MonoBehaviour
{
    public Transform startPoint;    // Starting point of the platform
    public Transform endPoint;      // Ending point of the platform
    public float speed = 2f;        // Speed of the platform

    private Rigidbody2D rb2d;
    private Vector3 nextPosition;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        nextPosition = startPoint.position;
    }

    void Update()
    {
        MovePlatform();
    }

    void MovePlatform()
    {
        // Move the platform towards the next position
        transform.position = Vector3.MoveTowards(transform.position, nextPosition, speed * Time.deltaTime);

        // Check if the platform has reached the next position
        if (Vector3.Distance(transform.position, nextPosition) < 0.1f)
        {
            // Switch to the other endpoint
            if (nextPosition == startPoint.position)
                nextPosition = endPoint.position;
            else
                nextPosition = startPoint.position;
        }
    }
}
