using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed = 5;
    public float turnSpeed = 10.0f;
    public float hInput;
    public float vInput;

    public float xRange = 10f;
    public float yRange = 4.5f;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        //
        transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime * hInput);
        //makes forward and yeha
        transform.Translate(Vector3.up * speed * Time.deltaTime * vInput);

    if (transform.position.x > xRange)
    {
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
    }
     if (transform.position.x < -xRange)
    {
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
    }
    if (transform.position.y > yRange)
    {
        transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
    }
     if (transform.position.y < -yRange)
    {
        transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
    }
    
    }
}
