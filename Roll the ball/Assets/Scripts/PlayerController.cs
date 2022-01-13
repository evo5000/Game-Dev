using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// NOTE FOR SELF THIS IS ONLY SLIGHTLY HANGING ON DONT TRY TO FIX ANYTHING ITS WORKING FOR NOW BUT VERY EASY TO BREAK
public class PlayerController : MonoBehaviour {
	//declare the stuff
	public Text winText;
	public float speed;
	private Rigidbody rb;
	public Text countText;
	private int count;
	void Start() 
	{
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		// ok soooooo ummmm we need this but every time i put you back in everything dies again sooooo ima just leave this here XD
		//000000000000000000000000
		//wintext.text = "";
		//000000000000000000000000
	}
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);
	}
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up")) 
		{	
			other.gameObject.SetActive (false);


			count = count + 1;
			SetCountText ();
		}
	}
	void SetCountText ()
	{
		//this needs to = the amount of pills there are
		countText.text = "Count: " + count.ToString (); 
		if (count >= 15) 
		{
			winText.text = "win.exe";
		}

	}

}