using UnityEngine;
using System.Collections;

 public class GhostStun : MonoBehaviour {

	 bool lightCheck;
	 FlashLight flash;
	 public GameObject ghost;
 
	
 	void Start () {
 		flash = gameObject.GetComponentInChildren<Light>().GetComponentInChildren<FlashLight>();
		 print("Obj:" + flash);
		 flash.isLightOn();
		 Print("Start"+ flash.isLightOn());
 	}


 	void Update () {
	 }
 	 	
	void OnTriggerEnter(Collider other){
		 print(Other.gameObject.name);
		 print ("Collider"+flash);

		if(other.gameObject.name == "Ghost" && flash == true){
		print("Ghost is stuned!");
		other.GetComponent<GhostAI>().moveSpeed = 0f;
		StartCoroutine(Wait(5));
		 	}
	 	}
 	
		 IEnumerator Wait(float time ){
			 	yield return new WaitForSeconds(time);
				ghost.GetComponent<GhostAI>().moveSpeed = 5f;
				print("Ghost is unstunned");
		
	}
}