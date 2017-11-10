﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FlashLight : MonoBehaviour {


public bool lightOn = true;

	Light light;

	void Start () {
		light = GetComponent<Light> ();

		lightOn = true;
		light.enabled = true;
	
	}
	
	
	void Update () {
		if (Input.GetKeyUp (KeyCode.L) && lightOn){
			lightOn = false;
			light.enabled = false;

		}
		else if (Input.GetKeyUp (KeyCode.L) && !lightOn){
			lightOn = true;
			light.enabled=true;
		}
	}
	public void setLightOn(){
			lightOn = true;
	}
	public bool isLightOn(){
				return lightOn;
	}
	
}
