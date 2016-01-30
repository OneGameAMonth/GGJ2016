using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		//Debug.Log("collision");
		//Destroy(other.gameObject);
		Player.Transform.right += 10.0f;
	}
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
