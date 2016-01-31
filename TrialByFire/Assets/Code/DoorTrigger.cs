using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {

	public PortalController portal;
	public GameObject spawnPoint;
    public Camera main;

	private string bottomDoorTag;
	private Vector3 roomCameraPosition;

	void OnTriggerEnter2D(Collider2D other) {
		//Debug.Log("collision");
		//Destroy(other.gameObject);
		//other.transform.Translate (new Vector2 (10.0f, 0f));
        if (gameObject.tag == "TopDoor")
        {
            Debug.Log("TopDoorCollision");
			portal.doorSlam.Play();
			main.transform.position = roomCameraPosition;
			other.transform.position = spawnPoint.transform.position;
        }
		else if(gameObject.tag == bottomDoorTag && other.GetComponent<PlayerController>().carryingTorch )
        {
            Debug.Log("BottomDoorCollision");
			main.transform.position = new Vector3(0f, 0f, -10f);
			other.transform.position = spawnPoint.transform.position;
			portal.increaseLevel();
        }
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void SetPortalController( PortalController p ){ portal = p; }
	public void SetDoorInformation( string tag, Vector3 cameraPos ){
		bottomDoorTag = tag; roomCameraPosition = cameraPos;
	}
	public void SetTag( string t ){ bottomDoorTag = tag; }
}
