using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonMovement : MonoBehaviour
{
    Rigidbody rb;
    float horizontalInput;
    float verticalInput;
    [SerializeField] float speed = 1.0f;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
    }

    private void FixedUpdate()
    {
        Vector3 dir = new(-verticalInput, 0, -horizontalInput);
        Walk(dir);
    }

    void Walk(Vector3 dir)
    {
        rb.velocity = new Vector3(rb.velocity.x ,rb.velocity.y , dir.z * Time.deltaTime * speed);
    }
}
