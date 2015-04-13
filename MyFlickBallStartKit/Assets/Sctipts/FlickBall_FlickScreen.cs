using UnityEngine;
using System.Collections;

public class FlickBall_FlickScreen : MonoBehaviour {

	public FlickBall_FlickBall currBall;

	private Vector3 startPosition;
	private Vector3 endPosition;
	private float startTime;
	private float endTime;
	// Use this for initialization
	void Start () {
	
	}

	private bool canSwap = false;
	// Update is called once per frame
	void Update () {

		// press down 
		if (Input.GetMouseButtonDown (0)) {
			startPosition = Input.mousePosition;
			startTime = Time.timeSinceLevelLoad;
		}

		//pressing
		if (Input.GetMouseButton (0)) {
			Vector3 touchPosition = Input.mousePosition;
			Vector3 deltaPositon = touchPosition - startPosition;

			if(deltaPositon!=Vector3.zero){
				canSwap = true;
			} else {
				canSwap = false;
			}

		}

		//press up
		if (Input.GetMouseButtonUp (0)) {

			endPosition = Input.mousePosition;
			endTime = Time.timeSinceLevelLoad;
			float time = endTime - startTime;

			if(canSwap&&GlobalStatus.CurrentGameStatus == GlobalStatus.GameStatus.BallStatus_WaitShoot){
				currBall.FlickBall(startPosition,endPosition,time);
				Debug.Log("Swap!!");
				GlobalStatus.CurrentGameStatus = GlobalStatus.GameStatus.BallStatus_Rolling;
			}
		}
	
	}
}
