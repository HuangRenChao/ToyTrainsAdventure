using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {

	public AudioClip[] musics;

	private SceneControl sceneControl;
	private AudioSource audioSource;
	// Use this for initialization
	void Start () {
		sceneControl = GameObject.FindObjectOfType<SceneControl> ();
		audioSource = GetComponent<AudioSource> ();

		if(!sceneControl.isGameOver){
			audioSource.clip = musics [0];
			audioSource.loop = true;
			audioSource.Play ();
		}

	}



	
	// Update is called once per frame
	void Update () {
	
	}
}
