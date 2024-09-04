using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn; // The object you want to spawn
    public Transform spawnLocation;  // The location where the object will be spawned
    public UnityEvent onSpawnEvent;  // Unity Event for spawning

    // Call this method to spawn the object
    public void SpawnObject()
    {
        if (objectToSpawn != null && spawnLocation != null)
        {
            Instantiate(objectToSpawn, spawnLocation.position, spawnLocation.rotation);
            onSpawnEvent.Invoke(); // Invoke any events tied to spawning
        }
    }
}
