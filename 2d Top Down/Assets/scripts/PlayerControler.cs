using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float speed = 5;
    public float turnSpeed = 10.0f;
    public float hInput;
    public float vInput;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        //
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * hInput);
        //makes forward and yeha
        transform.Translate(Vector3.forward * speed * Time.deltaTime * vInput);

    }
}
