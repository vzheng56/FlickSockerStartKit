using UnityEngine;
using System.Collections;

public class FlickBall_InitBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void InitBall(){
		GameObject currentBall = Instantiate (Resources.Load ("Soccer")) as GameObject;
		currentBall.name = "MyBall";

		float position_X = Random.Range (-53, -63);
		float position_Z = Random.Range (14, 78);

		currentBall.transform.position = new Vector3 (position_X, currentBall.transform.position.y,
		                                             position_Z);


	}
}
