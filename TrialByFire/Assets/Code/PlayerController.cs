using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public Animator anim;
	public float speed;
	public bool carryingTorch = false;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		float mod = speed * Time.deltaTime;
		float horizontal = Input.GetAxisRaw("Horizontal");
		float vertical = Input.GetAxisRaw("Vertical");

		if(vertical == 1f ){ anim.SetInteger("Direction", 3); }//up
		else if(vertical == -1f){ anim.SetInteger("Direction", 1); }//down
		else if(horizontal == 1f ){ anim.SetInteger("Direction", 2); }//right
		else if(horizontal == -1f ){ anim.SetInteger("Direction", 4); }//left
		GetComponent<Rigidbody2D>().velocity=new Vector2(horizontal * mod, vertical * mod);
		//transform.Translate(Input.GetAxis("Horizontal") * mod, Input.GetAxis("Vertical") * mod, 0f);
		// this is a stupid comment
	}

	void OnCollisionEnter2D(Collision2D coll) {
		GameObject gObj = coll.gameObject;
		if( gObj.name == "Torch" ){
			Destroy(coll.gameObject);
			carryingTorch = true;
		}
		if( gObj.name == "Bonfire" && carryingTorch == true){
			//swap the sprite on the bonfire to the lit sprite
			//gameObject.getComponent<Renderer>()
			gObj.GetComponent<BonfireController>().Light();
			carryingTorch = false;
		}
	}
}