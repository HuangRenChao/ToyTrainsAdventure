using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float movingSpeed = 1f;

	private CardboardHead head;

	// Use this for initialization
	void Start () {
		head = GameObject.FindObjectOfType<CardboardHead> ();

	}
	
	// Update is called once per frame
	void Update () {
		MoveForward ();
		Debug.Log (LookDirection ());
	}

	void MoveForward () {
		transform.position += Vector3.forward * movingSpeed * Time.deltaTime;
	}


	public Vector3 LookDirection() {
		return Vector3.ProjectOnPlane (head.Gaze.direction, Vector3.up);
	}


	void OnCollisionEnter (Collision collision) {
		Debug.Log ("Player's Collision!");
	}

}
