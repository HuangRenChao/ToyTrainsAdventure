using UnityEngine;
using System.Collections;

public class RailSpawner : MonoBehaviour {

	public GameObject[] railPrefab;
	public float railOffset = 3f;

	// Use this for initialization
	void Start () {
		Cardboard.SDK.OnTrigger += PullTrigger; // Trigger pull PullTrigger()

	}

	void Update() {
		Debug.Log (transform.position);
	}

	void InstantiateRail(int railIndex, float railOffset){
		GameObject railObject = Instantiate (railPrefab [railIndex]);
		Player player = GameObject.FindObjectOfType<Player> ();

		Vector3 lookDirection = player.LookDirection ();
		Vector3 playerPosition = player.transform.position;
		Vector3 railPostion = playerPosition + Vector3.down;

		railObject.transform.position = railPostion + lookDirection * railOffset;
		railObject.transform.parent = transform;

	}

	void PullTrigger () {
		Debug.Log ("Trigger Pulled, Look direction: ");

		InstantiateRail (0, railOffset);
	}

}
