﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	private int count;
	public Text countText;
	public Text winText;
	public Slider speedSlider;

	void Start () {
		rb = GetComponent<Rigidbody> (); 
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement*speed);
		speed = speedSlider.value;
	}
		

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ( "Pickups"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}

	void SetCountText(){
		countText.text = "Count :" + count.ToString ();
		if (count == 10) {
			winText.text = "You win!";
		}
	}
}
