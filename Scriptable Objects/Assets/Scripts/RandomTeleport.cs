using UnityEngine;
using UnityEngine.Events;

public class RandomTeleport : MonoBehaviour
{
    [SerializeField] private GameObject Xp;
    public UnityEvent onTeleport; // Event that gets triggered upon teleportation
    public Transform objectToTeleport; // The object that will be teleported
    public Vector3 minPosition; // Minimum bounds for random teleportation
    public Vector3 maxPosition; // Maximum bounds for random teleportation

    // Method to teleport the object to a random position within the defined area
    public void TeleportObject()
    {
        if (objectToTeleport != null)
        {
            // Generate a random position within the bounds
            Vector3 randomPosition = new Vector3(
                Random.Range(minPosition.x, maxPosition.x),
                Random.Range(minPosition.y, maxPosition.y),
                Random.Range(minPosition.z, maxPosition.z)
            );

            // Set the object's position to the random position
            objectToTeleport.position = randomPosition;

            
            onTeleport.Invoke();
        }
        else
        {
            Debug.LogWarning("No object assigned for teleportation.");
        }
    }
}