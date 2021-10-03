using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    HingeJoint2D joint;
    float maxSpeed;

    float gas;

    // Start is called before the first frame update
    void Start()
    {
        joint = gameObject.GetComponent<HingeJoint2D>();
        maxSpeed = gameObject.transform.GetComponentInParent<Robot>().maxSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        gas = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        var motor = joint.motor;

        motor.motorSpeed = gas * maxSpeed;
        joint.motor = motor;
    }
}
