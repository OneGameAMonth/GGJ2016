using UnityEngine;
using System.Collections;

public class Pressure_Plate : MonoBehaviour {

	public GameObject torchObj;
	private SpriteRenderer torchRenderer;

	// Use this for initialization
	void Start () {
		torchRenderer = torchObj.GetComponent<SpriteRenderer>();
		torchRenderer.enabled = false;
		torchObj.GetComponent<BoxCollider2D>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Sense when a weighted object is pressing down
	void OnTriggerExit2D(Collider2D other) {
		if( torchRenderer != null ){ torchRenderer.enabled = false; }
		torchObj.GetComponent<BoxCollider2D>().enabled = false;
	}
	void OnTriggerStay2D(Collider2D other) {
		if( torchRenderer != null ){ torchRenderer.enabled = true; }
		torchObj.GetComponent<BoxCollider2D>().enabled = true;
	}

}
