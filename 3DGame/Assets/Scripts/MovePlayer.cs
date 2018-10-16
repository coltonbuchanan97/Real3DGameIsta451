using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    private Rigidbody rigidBody;
    private Vector3 moveDelta;
    public float speed = 8f;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        moveDelta = new Vector3(x, 0.0f, z) * speed * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        RotateIfNewDirection(moveDelta);
        rigidBody.MovePosition(rigidBody.position + moveDelta);
    }

    private void RotateIfNewDirection(Vector3 input)
    {
        if (input.magnitude < 0.01f)
            return;

        rigidBody.rotation = Quaternion.LookRotation(input);
    }
}