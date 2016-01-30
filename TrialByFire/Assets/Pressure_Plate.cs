﻿using UnityEngine;
using System.Collections;

public class Pressure_Plate : MonoBehaviour {

	public GameObject torchObj;
	private SpriteRenderer torchRenderer;

	// Use this for initialization
	void Start () {
		torchRenderer = torchObj.GetComponent<SpriteRenderer>();
		torchRenderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Sense when a weighted object is pressing down
	void OnTriggerExit2D(Collider2D other) {
		torchRenderer.enabled = false;
	}
	void OnTriggerStay2D(Collider2D other) {
		torchRenderer.enabled = true;
	}

}
