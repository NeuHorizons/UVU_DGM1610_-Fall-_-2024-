using UnityEngine;

public class MovementChecker : MonoBehaviour
{
    public Animator animator;              // Reference to the Animator component
    private CharacterController controller; // Reference to the CharacterController
    private Vector3 lastPosition;         // Stores the last position of the object
    public float movementThreshold = 0.01f; // Minimum movement distance to be considered "moving"

    void Start()
    {
        // Get the CharacterController component attached to the object
        controller = GetComponent<CharacterController>();

        // Initialize the last position
        lastPosition = transform.position;
    }

    void Update()
    {
        // Calculate horizontal movement only (ignoring vertical movement)
        Vector3 horizontalMovement = new Vector3(
            transform.position.x - lastPosition.x,
            0,
            transform.position.z - lastPosition.z
        );

        // Check if the magnitude of the horizontal movement exceeds the threshold
        bool isMoving = horizontalMovement.sqrMagnitude > movementThreshold * movementThreshold;

        // Update the Animator parameter
        if (animator != null)
        {
            animator.SetBool("isMoving", isMoving);
        }

        // Update the last position
        lastPosition = transform.position;
    }
}

