using UnityEngine;
using System.Collections;

public class MovingObstacleSpawner : MonoBehaviour {
	public GameObject movingObstaclePrefab;
	public float spawnPeriodInSecs;
	public float remainingTimeInSecs;

	private int randomIndex;
	private PathMove pathMove;
	// Use this for initialization
	void Start () {
		pathMove = GameObject.FindObjectOfType<PathMove> ();
		StartCoroutine (Spawn());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Spawn(){
		while (true){
			WaitForSeconds waitInSecs = new WaitForSeconds (spawnPeriodInSecs);
			yield return waitInSecs;

			InstantiateMovingObstacle ();
		}
	}

	IEnumerator DestroyObstacle(GameObject obstacle){
		while (true){
			WaitForSeconds waitInSecs = new WaitForSeconds (remainingTimeInSecs);
			yield return waitInSecs;

			Destroy (obstacle);
		}
	}



	Vector3 RandomPosition(){
		randomIndex = Random.Range (0, 30);
		return pathMove.wayPoints [randomIndex].position;
	}

	void InstantiateMovingObstacle(){
		GameObject movingObstacle = Instantiate (movingObstaclePrefab);
		movingObstacle.transform.position = RandomPosition ();
		movingObstacle.transform.parent = transform;

		StartCoroutine(DestroyObstacle(movingObstacle));


	}




}
