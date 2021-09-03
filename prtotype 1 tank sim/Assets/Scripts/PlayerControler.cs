using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float Speed;

    public float TurnSpeed;

    public float hInput;

    public float vInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        //transform.position(Vector3(0,0,0));
        //dosnt move tank forword
        transform.Translate(Vector3.forward * Speed * Time.deltaTime * vInput);
        transform.Rotate(Vector3.up, TurnSpeed * hInput * Time.deltaTime );
    }
}
