using UnityEngine;
using System.Collections;

public class BonfireController : MonoBehaviour {
	public GameObject unlit;
	public GameObject lit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Light(){
		lit.SetActive(true);
		unlit.SetActive(false);
	}

	public void Extinguish(){
		lit.SetActive(false);
		unlit.SetActive(true);
	}
}
