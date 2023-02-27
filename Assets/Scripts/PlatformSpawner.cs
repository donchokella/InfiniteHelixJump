using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject[] platformPrefabs;
    private Transform getPos;
    private Vector3 newPos;
    private float randomRotation;

    public AudioClip scoreSound;

    public float spawnPos;
    public Transform ball;

    private void Update()
    {
        if (ball.position.y + 2 < gameObject.transform.position.y)
        {
            Debug.Log("hop");
            InstantiatePlatform();
        }

    }

    public void InstantiatePlatform()
    {
        getPos = gameObject.GetComponent<Transform>();
        newPos = getPos.position + new Vector3(0, spawnPos, 0);
        randomRotation = Random.Range(0, 360);

        GameObject newPlatform = Instantiate(platformPrefabs[Random.Range(0, platformPrefabs.Length)]);
        newPlatform.transform.position = newPos;
        newPlatform.transform.rotation = Quaternion.Euler(0, randomRotation, 0);

        Destroy(transform.parent.gameObject);
        AudioSource.PlayClipAtPoint(scoreSound, transform.position);
    }
}
