using UnityEngine;
using System.Collections;

public class MusicController : MonoBehaviour {
	public AudioSource intro;
	public AudioSource loop;

	// Use this for initialization
	void Start () {
		StartCoroutine(PlayMusic());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator PlayMusic(){
		intro.Play();
		yield return new WaitForSeconds(intro.clip.length);
		loop.Play();
	}
}
