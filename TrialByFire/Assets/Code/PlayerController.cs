using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public bool isCarryingTorch = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float mod = speed * Time.deltaTime;
		GetComponent<Rigidbody2D>().velocity=new Vector2(Input.GetAxisRaw("Horizontal") * mod, Input.GetAxisRaw("Vertical") * mod);
		//transform.Translate(Input.GetAxis("Horizontal") * mod, Input.GetAxis("Vertical") * mod, 0f);
		// this is a stupid comment
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if( coll.gameObject.name == "Torch2" ){
			Destroy(coll.gameObject);
			isCarryingTorch = true;
		}
		if( coll.gameObject.name == "Bonfire" && isCarryingTorch == true){
			//swap the sprite on the bonfire to the lit sprite
			gameObject.getComponent<Renderer>()
			isCarryingTorch = false;
		}
	}
}