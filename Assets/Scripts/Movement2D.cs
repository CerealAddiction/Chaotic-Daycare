using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3D : MonoBehaviour
{
    Rigidbody body;

    float horizontal;
    float vertical;

    public float runSpeed = 20.0f;

    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector3(horizontal * runSpeed, vertical * runSpeed);
    }
}