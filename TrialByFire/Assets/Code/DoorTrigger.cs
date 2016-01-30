using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {

	public GameObject spawnPoint;
	public Camera main;

	void OnTriggerEnter2D(Collider2D other) {
		//Debug.Log("collision");
		//Destroy(other.gameObject);
		//other.transform.Translate (new Vector2 (10.0f, 0f));
		other.transform.position = spawnPoint.transform.position;
		main.transform.Translate (new Vector2 (12.9f, 0f));
	}
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
