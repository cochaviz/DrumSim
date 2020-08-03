using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampRotation : MonoBehaviour
{
    public float torque;
    public float threshold;
    Vector3 startRotation;
    Rigidbody rigidBody;
    void Start()
    {
        startRotation = transform.rotation.eulerAngles;
        rigidBody = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        Vector3 difference = (transform.rotation.eulerAngles - startRotation);
        if (Mathf.Abs(difference.magnitude) > threshold)
        {
            rigidBody.AddTorque(torque * difference);
        } 
    }
}
