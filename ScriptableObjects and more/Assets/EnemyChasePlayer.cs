using UnityEngine;

public class EnemyChasePlayer : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float speed = 5f; // Speed of the enemy
    public float chaseDistance = 10f; // Distance at which the enemy starts chasing the player

    void Update()
    {
        // Calculate the distance between the enemy and the player
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Check if the player is within the chase distance
        if (distanceToPlayer <= chaseDistance)
        {
            // Calculate the direction from the enemy to the player
            Vector3 direction = player.position - transform.position;
            direction.Normalize();

            // Move the enemy towards the player
            transform.position += direction * speed * Time.deltaTime;

            // Rotate the enemy to face the player
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * speed);
        }
    }
}
