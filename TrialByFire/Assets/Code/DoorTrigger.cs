﻿using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {

	//Teleport the player on collision
	void OnTriggerEnter2D(Collider2D other) {
		//Debug.Log("collision");
		//Destroy(other.gameObject);
		other.transform.Translate(Vector2.right*10.0f);
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
