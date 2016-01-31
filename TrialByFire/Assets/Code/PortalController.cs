using UnityEngine;
using System.Collections;

public class PortalController : MonoBehaviour {
	public AudioSource doorSlam;
	public bool doorLocked = false;
	//public DoorTrigger doorTriggers;
	public DoorTrigger bonfireDoorTrigger;
	public string[] doorTags;
	public Vector3[] cameraPositions;
	public GameObject[] spawnpoints;
	public DoorTrigger[] triggers;
	private int currentLevel = 0;

	// Use this for initialization
	void Start () {
		currentLevel = 0;
		bonfireDoorTrigger.SetPortalController(this);
		bonfireDoorTrigger.spawnPoint = spawnpoints[currentLevel];
		bonfireDoorTrigger.SetDoorInformation( doorTags[currentLevel], cameraPositions[currentLevel] );
		for(int i = 0; i < triggers.Length; i++){
			triggers[i].SetTag(doorTags[i]);
			triggers[i].SetPortalController(this);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void increaseLevel(){
		if( currentLevel < spawnpoints.Length-1 ){
			currentLevel++;
			bonfireDoorTrigger.spawnPoint = spawnpoints[currentLevel];
			bonfireDoorTrigger.SetDoorInformation( doorTags[currentLevel], cameraPositions[currentLevel] );
		}
		//doorTriggers[currentLevel].
	}
}
