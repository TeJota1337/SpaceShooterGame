using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[SelectionBase]
public class Enemy : MonoBehaviour
{

    public float force;
    Rigidbody rb;
    private Transform playerRef;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerRef = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerRef);
        rb.AddForce(transform.forward * force, ForceMode.Impulse);
    }
}
    