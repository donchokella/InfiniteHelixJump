using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    Rigidbody rb;
    public float bounceVel;

    public AudioClip hitSound;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
   
    }
    private void OnCollisionEnter(Collision other)
    {
        rb.velocity = new Vector3(0, bounceVel, 0);
      
        AudioSource.PlayClipAtPoint(hitSound, transform.position);
    }
}
