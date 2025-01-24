using UnityEngine;

public class CameraPanController : MonoBehaviour
{
    // Starting position and rotation
    private Vector3 startPosition = new Vector3(34.3f, 4.5f, 73.14f);
    private Quaternion startRotation = Quaternion.Euler(0.85f, 183.301f, -0.587f);

    
    private Vector3 targetPosition = new Vector3(33.94f, 4.5f, 69.14f);
    private Quaternion targetRotation = Quaternion.Euler(-2.346f, 90.433f, -0.417f);

    public float moveSpeed = 5f; 
    public float rotationSpeed = 5f; 
    private bool isMoving = false; 

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
            transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            // Rotate the camera towards the target rotation using Slerp for smoothness
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

            // Check if the camera is close enough to the target position and rotation
            if (Vector3.Distance(transform.position, targetPosition) < 0.1f && Quaternion.Angle(transform.rotation, targetRotation) < 0.1f)
            {
                isMoving = false; // Stop moving when close enough
            }
        }
    }

    public void MoveCamera()
    {
        isMoving = true; // Start the movement process
    }
}