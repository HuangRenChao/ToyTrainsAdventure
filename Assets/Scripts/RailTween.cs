using UnityEngine;
using System.Collections;

public class RailTween : MonoBehaviour {

//	public Transform[] trans;
//	
////	LTSpline pathPoints;
//
//	private GameObject player;
//
//
//
//
//	void Start () {
//		player = GameObject.Find("Player");
//		if(pathPoints != null){
//			OnEnable ();
//		} 
//
//	}
//	
//
//	void Update () {
//
//
//
//	}
//
//	void OnCollisionEnter(Collision collision){
//		if(collision != null){
//			LeanTween.moveSpline(player, pathPoints.pts, 5f).setOrientToPath(true).setLoopOnce().setDirection(1f);
//		}
//	}
//
//	void OnEnable(){
//		// create the path
//		pathPoints = new LTSpline( new Vector3[] {trans[0].position, trans[1].position, trans[2].position, trans[3].position, trans[4].position} );
//		// cr = new LTSpline( new Vector3[] {new Vector3(-1f,0f,0f), new Vector3(0f,0f,0f), new Vector3(4f,0f,0f), new Vector3(20f,0f,0f), new Vector3(30f,0f,0f)} );
//	}
//
////	void OnDrawGizmos(){
////		// Debug.Log("drwaing");
////		if(pathPoints!=null)
////			OnEnable();
////		Gizmos.color = Color.red;
////		if(pathPoints!=null)
////			pathPoints.gizmoDraw(); // To Visualize the path, use this method
////	}
//
//	void UpdateIteration(float iter){
//		iter += Time.deltaTime*0.07f;
//		if(iter>1.0f)
//			iter = 0.0f;
//	}
}