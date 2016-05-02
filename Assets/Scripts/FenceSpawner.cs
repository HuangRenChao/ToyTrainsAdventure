using UnityEngine;
using System.Collections;

public class FenceSpawner : MonoBehaviour {
	public GameObject userFence;

	private Player player;

	// Use this for initialization
	void Start () {
		Cardboard.SDK.OnTrigger += PullTrigger;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void InstantiateFence(){
		player = GameObject.FindObjectOfType<Player> ();

		Vector3 lookDirection = player.LookDirection ();
		Vector3 playerRotation = player.PlayerRotation ();

		GameObject userFenceObject = Instantiate (userFence);
		userFenceObject.transform.position = lookDirection * 10;
		userFenceObject.transform.rotation = Quaternion.Euler (playerRotation);
		userFenceObject.transform.parent = transform;


	}

	void PullTrigger () {
		InstantiateFence ();
	}

}
