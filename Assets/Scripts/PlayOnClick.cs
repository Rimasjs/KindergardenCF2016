using UnityEngine;
using System.Collections;

public class PlayOnClick : MonoBehaviour {

	private AudioSource sound;
	private bool isPlaying = false;
	private Renderer;

	// Initializing the Audio Source
	void Start () {
		sound = GetComponent<AudioSource> ();

	}

	void Update(){
		if (isPlaying) {

		}
	}

	void OnMouseDown(){
		sound.Play ();
	}
}
