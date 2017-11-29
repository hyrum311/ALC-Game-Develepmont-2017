using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class FlashLight : MonoBehaviour {


public bool lightOn = true;
//Flashlight power capacity
	public int maxPower = 4;
//Useable flashlight power
	public int currentPower;

	public int batDrainAmt;

	public float batDrainDelay;

	Light light;

	public Text batteryText;

	void Start () {
		currentPower = maxPower;
		print("Power =" + currentPower);
		light = GetComponent<Light> ();

		lightOn = true;
		print("turn light on when flashlight is initiated");
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
		batteryText.text = currentPower.ToString();

		if(currentPower > 0){
				StartCoroutine(BatteryDrain(batDrainDelay,batDrainAmt));
		}
	}
	public void setLightOn(){
			lightOn = true;
	}
	public bool isLightOn(){
				return lightOn;
	
	}
	IEnumerator BatteryDrain(float delay, int amount){
		yield return new WaitForSeconds(delay);
		currentPower -= amount;
		if(currentPower <= 0){
			currentPower = 0;
			print("Battery is dead!");
			light.enabled = false;
		
		}
	}
	
}
