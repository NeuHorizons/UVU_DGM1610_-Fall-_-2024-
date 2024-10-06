using UnityEngine;

public class RandomTeleport : MonoBehaviour
{
    
    public Vector3 minBoundary; 
    public Vector3 maxBoundary; 
    
    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.T))
        {
            Teleport();
        }
    }

    
    public void Teleport()
    {
        
        float randomX = Random.Range(minBoundary.x, maxBoundary.x);
        float randomY = Random.Range(minBoundary.y, maxBoundary.y);
        float randomZ = Random.Range(minBoundary.z, maxBoundary.z);

        
        transform.position = new Vector3(randomX, randomY, randomZ);
    }
}