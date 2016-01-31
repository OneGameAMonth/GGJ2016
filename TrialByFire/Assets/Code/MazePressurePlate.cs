using UnityEngine;
using System.Collections;

public class MazePressurePlate : MonoBehaviour {
	
	public GameObject torchObj;
	public GameObject maze1;
	public GameObject maze2;
	private SpriteRenderer torchRenderer;
	
	// Use this for initialization
	void Start () {
		torchRenderer = torchObj.GetComponent<SpriteRenderer>();
		maze1.SetActive(true);
		maze2.SetActive(false);
		torchObj.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	//Sense when a weighted object is pressing down
	void OnTriggerExit2D(Collider2D other) {
		if( torchRenderer != null ){ 
			torchObj.SetActive (false);
			maze2.SetActive(false);
			maze1.SetActive(true);
		}
	}
	void OnTriggerStay2D(Collider2D other) {
		if( torchRenderer != null ){ 
			torchObj.SetActive (true);
			maze2.SetActive(true);
			maze1.SetActive(false);
		}
	}
	
}
