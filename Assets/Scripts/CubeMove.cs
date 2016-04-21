using UnityEngine;
using System.Collections;

public class CubeMove : MonoBehaviour {

	public float movingSpeed = 1f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.forward * movingSpeed * Time.deltaTime;
	}
}
