using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicPewPew : MonoBehaviour
{
    public float speed;
    public GameObject Magic;
    public Transform player;


    // Update is called once per frame
    void Update()
    {
       transform.Translate(Vector3.up * speed * Time.deltaTime); 
    }
}
