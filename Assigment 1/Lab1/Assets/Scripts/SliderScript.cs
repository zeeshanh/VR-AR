using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderScript : MonoBehaviour {

	public PlayerController ball;

	void onValueChanged(int newValue){
		
		ball.speed = newValue;
	}
}

	
