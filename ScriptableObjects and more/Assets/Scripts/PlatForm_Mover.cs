using System.Collections;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public float target;
    public float waitTime; 
    public float moveDuration = 2f;
    public GameObject platform;

    private Vector3 startPosition;

    void Start()
    {
        if (platform != null)
        {
            startPosition = platform.transform.position;
            StartCoroutine(MovePlatform());
        }
    }

    IEnumerator MovePlatform()
    {
        Vector3 targetPosition = startPosition + Vector3.back * target;
        float elapsedTime = 0f;

        while (elapsedTime < moveDuration)
        {
            platform.transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / moveDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        platform.transform.position = targetPosition;

        yield return new WaitForSeconds(waitTime); 

        elapsedTime = 0f;

        while (elapsedTime < moveDuration)
        {
            platform.transform.position = Vector3.Lerp(targetPosition, startPosition, elapsedTime / moveDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        platform.transform.position = startPosition;

        yield return new WaitForSeconds(waitTime); 

        StartCoroutine(MovePlatform());
    }
}