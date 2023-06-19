using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 5f;

    private void Update()
    {
        // Get horizontal and vertical input axes
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);

        // Normalize movement vector to maintain consistent speed
        movement.Normalize();

        // Calculate target position based on movement input
        Vector3 targetPosition = transform.position + movement * movementSpeed * Time.deltaTime;

        // Update the cube's position
        transform.position = targetPosition;
    }
}
