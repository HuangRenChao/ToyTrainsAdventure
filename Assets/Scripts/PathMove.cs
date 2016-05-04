using UnityEngine;
using System.Collections;

public class PathMove : MonoBehaviour {
	public Transform[] wayPoints;
	public GameObject movingObject;
	public float RotationDurationInSeconds;
	LTSpline cr;


	void OnEnable(){
		// create the path
		cr = new LTSpline( new Vector3[] {wayPoints[0].position, wayPoints[1].position, wayPoints[2].position, wayPoints[3].position, wayPoints[4].position,
			wayPoints[5].position, wayPoints[6].position, wayPoints[7].position, wayPoints[8].position, wayPoints[9].position, wayPoints[10].position,
			wayPoints[11].position, wayPoints[12].position, wayPoints[13].position, wayPoints[14].position, wayPoints[15].position, wayPoints[16].position,
			wayPoints[17].position, wayPoints[18].position, wayPoints[19].position, wayPoints[20].position, wayPoints[21].position, wayPoints[22].position,
			wayPoints[23].position, wayPoints[24].position, wayPoints[25].position, wayPoints[26].position, wayPoints[27].position, wayPoints[28].position,
			wayPoints[29].position, wayPoints[30].position
		} );

	}

	void Start () {

		MoveTrain ();

	}
	

	void Update () {

	}

	void OnDrawGizmos(){
		// Debug.Log("drwaing");
		if(cr!=null)
			OnEnable();
		Gizmos.color = Color.red;
		if(cr!=null)
			cr.gizmoDraw(); // To Visualize the path, use this method
	}

	public void MoveTrain(){
		movingObject.SetActive (true);
		LeanTween.moveSpline(movingObject, cr.pts, RotationDurationInSeconds).setOrientToPath(true).setRepeat(-1).setDirection(1f);
	}

}
