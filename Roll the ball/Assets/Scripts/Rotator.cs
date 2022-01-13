using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotator : MonoBehaviour {

	void Update () {
		// x,y,z
		transform.Rotate(new Vector3 (10,25,45) * Time.deltaTime);

	}

}
