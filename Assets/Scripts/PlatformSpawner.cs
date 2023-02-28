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
    float spawnPos = -11;

    public Score score;


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.position.y < gameObject.transform.position.y)
        {
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

        AudioSource.PlayClipAtPoint(scoreSound, transform.position);

        score.Scored();
        Destroy(transform.parent.gameObject);

    }
}
