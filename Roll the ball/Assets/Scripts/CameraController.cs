using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public GameObject player;
 //it do the stuff dont toch it stops working if you touch bad no no code
	private Vector3 offset;
	void Start () {
		offset = transform.position - player.transform.position;
	}

		void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
