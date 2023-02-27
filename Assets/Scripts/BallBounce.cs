using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    Rigidbody rb;
    public float bounceVel;

    public AudioClip hitSound;

    public GameManager gameManager;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (gameManager.gameOver)
        {
            rb.constraints = RigidbodyConstraints.FreezePosition;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        AudioSource.PlayClipAtPoint(hitSound, transform.position);

        rb.velocity = new Vector3(0, bounceVel, 0);
        if (other.gameObject.GetComponent<MeshRenderer>().material.name == "UnSafeColor (Instance)")
        {
            gameManager.GameOver();
        }
    }
}
