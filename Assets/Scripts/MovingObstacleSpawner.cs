using UnityEngine;
using System.Collections;

public class MovingObstacleSpawner : MonoBehaviour {
	public GameObject movingObstaclePrefab;
	public float spawnPeriodInSecs;
	public float remainingTimeInSecs;

	private float spawnPeriodPhase2;
	private float spawnPeriodPhase3;
	private Timer timer;
	private int randomIndex;
	private PathMove pathMove;
	// Use this for initialization
	void Start () {
		pathMove = GameObject.FindObjectOfType<PathMove> ();
		timer = FindObjectOfType<Timer> ();
		spawnPeriodPhase2 = spawnPeriodInSecs / 2;
		spawnPeriodPhase3 = spawnPeriodInSecs / 4;
		InstantiateMovingObstacle ();
		StartCoroutine (Spawn());

	}
	
	// Update is called once per frame
	void Update () {
		spawnCurve ();

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

	public void spawnCurve(){
//		spawnPeriodInSecs = Mathf.Pow (timer.timePast, -1f);
		float timePast = timer.timePast;
		float timePoint1 = timer.totalGameTime / 3;
		float timePoint2 = timePoint1 * 2;
		float timePoint3 = timer.totalGameTime;


		if(timePast <= timePoint1){
			spawnPeriodInSecs = spawnPeriodInSecs;
		} else if (timePast <= timePoint2) {
			spawnPeriodInSecs = spawnPeriodPhase2;
		} else if (timePast <= timePoint3) {
			spawnPeriodInSecs = spawnPeriodPhase3;
		}




	}




}
