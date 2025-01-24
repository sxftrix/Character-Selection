using UnityEngine;

public class ChangeChar : MonoBehaviour
{
    // Starting position and rotation
    private Vector3 startPosition = new Vector3(33.96089f, 4.495179f, 69.23689f);
    private Quaternion startRotation = Quaternion.Euler(-2.346f, 90.433f, -0.417f);

    // Target position and rotation
    private Vector3 targetPosition = new Vector3(34.35f, 4.44f, 69.06f);
    private Quaternion targetRotation = Quaternion.Euler(0.671f, 267.372f, 0.785f);

    public float moveSpeed = 1f; 
    public float rotationSpeed = 5f; 
    private bool isMoving = false; 
    private bool isAtTarget = false; 

    void Start()
    {
        // Set the camera to the starting position and rotation
        transform.position = startPosition;
        transform.rotation = startRotation;
    }

    void Update()
    {
        if (isMoving)
        {
            // Move the camera towards the target position using Lerp for smoothness
            transform.position = Vector3.Lerp(transform.position, isAtTarget ? startPosition : targetPosition, moveSpeed * Time.deltaTime);
            // Rotate the camera towards the target rotation using Slerp for smoothness
            transform.rotation = Quaternion.Slerp(transform.rotation, isAtTarget ? startRotation : targetRotation, rotationSpeed * Time.deltaTime);

            // Check if the camera is close enough to the target position and rotation
            if (Vector3.Distance(transform.position, isAtTarget ? startPosition : targetPosition) < 0.1f &&
                Quaternion.Angle(transform.rotation, isAtTarget ? startRotation : targetRotation) < 0.1f)
            {
                isMoving = false; // Stop moving when close enough
                isAtTarget = !isAtTarget; // Toggle the target state
            }
        }
    }

    public void MoveCamera()
    {
        isMoving = true; // Start the movement process
    }
}