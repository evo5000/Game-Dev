using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Movement stuff
    public float moveSpeed;
    public float jump;

    // Camera stuuf
    public float lookSensitivity; //mouse look sencitivity
    public float maxLookX; //lowest you can look down
    public float minLookX; // the most up you can look
    private float rotX; // Current X rotation of camera


    private Camera cam;
    private Rigidbody rig;


    void Awake() 
    {
        //get the components
        cam = Camera.main;
        rig = GetComponent<Rigidbody>();
        //disable the camera from moving more
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void CamLook()
    {
        float y = Input.GetAxis("Mouse X") * lookSensitivity;
        rotX += Input.GetAxis("Mouse Y") * lookSensitivity;
    // vertical rotation
        rotX = Mathf.Clamp(rotX, minLookX, maxLookX);
        // acualy useing the rotation
        cam.transform.localRotation = Quaternion.Euler(-rotX, 0, 0);
        transform.eulerAngles += Vector3.up * y;
    }
     void Move() 
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;

        Vector3 dir = transform.right * x + transform.forward * z;
        
        dir.y = rig.velocity.y;
        rig.velocity = dir;

    }

}

   