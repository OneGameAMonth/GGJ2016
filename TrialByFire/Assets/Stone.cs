using UnityEngine;
using System.Collections;

public class Stone : MonoBehaviour {

	//Move stone when pushed by player
	void OnTriggerEnter2D(Collider2D other) {
		transform.Translate(Vector2.MoveTowards(gameObject.transform.position, other.transform.position, -1.0f));
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
