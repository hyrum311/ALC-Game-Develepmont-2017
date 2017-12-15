﻿using UnityEngine;
using System.Collections;

public class Battery_Spawn : MonoBehaviour {

	public Rigidbody battery;

	public Transform spawnPoint;

	public float spawnTime;

	public bool batSpawned;



	
	// Use this for initialization
	void Start () {
		batSpawned = false;

	}
	
	// Update is called once per frame
	void Update () {
	 if(batSpawned == false){
		 StartCoroutine(spawnBat(spawnTime, battery));
		

	 }
	 else{
		 
	}
	}

	void OnTriggerEnter(Collider other){
		if(other.Rigidbody.tag == "Battery"){
			batSpawned = true;
	}
		else{
			batSpawned = false;

		}
	}
	IEnumerator SpawnBat(float time, Rigidbody bat){
		yield return new WaitForSeconds(time);
		Instantiate(battery, spawnPoint.position, spawnPoint.rotation);


	}
 
}
