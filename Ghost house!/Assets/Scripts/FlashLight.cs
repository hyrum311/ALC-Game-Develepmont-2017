using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FlashLight : MonoBehaviour {


public bool lightOn = true;
//Flashlight power capacity
	public int maxPower = 4;
//Useable flashlight power
	public int currentPower;

	Light light;

	void Start () {
		currentPower = maxPower;
		print("Power =" + currentPower);
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
