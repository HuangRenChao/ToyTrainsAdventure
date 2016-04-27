using UnityEngine;
using System.Collections;

public class RotationTest : MonoBehaviour {

	public Vector3 rotationFactor = new Vector3(0,0,0);

	private Player player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindObjectOfType<Player> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerRotation = player.PlayerRotation ();
		Debug.Log (playerRotation);
		RotationTest roatationObject = GameObject.FindObjectOfType<RotationTest> ();
		roatationObject.transform.rotation = Quaternion.Euler (playerRotation);
	}


}
