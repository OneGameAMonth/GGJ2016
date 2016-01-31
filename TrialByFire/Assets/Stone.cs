using UnityEngine;
using System.Collections;

public class Stone : MonoBehaviour {

	public float thisIsTheFinalCountdown = 0f;
	public float deltaInput = 1f;
	public int keyComboStep = 0;

	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().enabled = false;
		GetComponent<BoxCollider2D>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (thisIsTheFinalCountdown > 0) {
			thisIsTheFinalCountdown -= Time.deltaTime;
		}

		char[] inputArr = {'s', 's', 'a', 'd', 's'};

		if (Input.anyKeyDown) {
			bool condition = (thisIsTheFinalCountdown > 0 || keyComboStep == 0 ) && Input.GetKeyDown( inputArr[keyComboStep].ToString() );
			if ( condition ) {
				thisIsTheFinalCountdown = deltaInput;
				keyComboStep += 1;
				if( keyComboStep == inputArr.Length ){
					GetComponent<Renderer>().enabled = true;
					GetComponent<BoxCollider2D>().enabled = true;
				}
			}
			if( keyComboStep == inputArr.Length || !condition ){
				thisIsTheFinalCountdown = 0f;
				keyComboStep = 0;
			}
		}
			
	}
}
