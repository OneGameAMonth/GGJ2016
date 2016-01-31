using UnityEngine;
using System.Collections;

public class TimerScript : MonoBehaviour {

	float initialTime = 240f;
	float timeLeft;
	Vector2 originalScale;

	// Use this for initialization
	void Start () {
		gameObject.tag = "RedBar";
		originalScale = gameObject.transform.localScale;
		timeLeft = initialTime;
	}
	
	// Update is called once per frame
	void Update () {
		if (timeLeft > 0) {
		
			timeLeft -= Time.deltaTime;
			gameObject.GetComponent<RectTransform> ().localScale = new Vector2((timeLeft / initialTime), originalScale.y);
		
		}
	}
}
