using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    public GameObject centerOfMass;
    public float maxSpeed;

    // Start is called before the first frame update
    void Start()
    {
        var body = gameObject.GetComponent<Rigidbody2D>();
        var com = centerOfMass.transform.localPosition;

        body.centerOfMass = com;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
