using UnityEngine;
using System.Collections;

 public class GhostStun : MonoBehaviour {

 //bool lightCheck;
	
 	void Start () {
 		//lightCheck = GetComponent<FlashLight>().LightOn;
 	}
	
	
 	void Update () {
	
 	} 	
	 void OnTriggerEnter(Collider other){
 		
 		if(other.gameObject.name == "Ghost") {

 			print("Ghost is Stunned!"); 
 		}
	}
 }
