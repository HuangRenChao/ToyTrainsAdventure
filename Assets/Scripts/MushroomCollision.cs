using UnityEngine;
using System.Collections;

public class MushroomCollision : MonoBehaviour {
	
	public AudioSource[] audioSource;
	public AudioSource mushroomPlace;
	public AudioSource destroyObstacle;

	// Use this for initialization
	void Start () {
		audioSource = GetComponents<AudioSource> ();
		mushroomPlace = audioSource [0];
		destroyObstacle = audioSource [1];

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter (Collider col){
		

		if(col.gameObject.name == "MovingObstacle"){
			Destroy (col.gameObject);
			destroyObstacle.Play ();

		}
	}

}

