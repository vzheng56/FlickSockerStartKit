using UnityEngine;
using System.Collections;

public class FlickBall_FlickBall : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
	}

	// shoot ball
	public void FlickBall(Vector3 startPosition,Vector3 endPosition,float time){

		Vector3 ballDirection = endPosition - startPosition;
		ballDirection.Normalize ();
		float angle = Mathf.Atan2 (ballDirection.x, ballDirection.y) * Mathf.Rad2Deg;
		ballDirection = endPosition - startPosition;

		// power

		float power = ballDirection.magnitude / time;
		Vector3 force = transform.rotation * 
			Quaternion.AngleAxis (angle, Vector3.up) * (new Vector3 (0, 0, power));

		GetComponent<Rigidbody> ().AddForce (force / 20, ForceMode.Impulse);
		//Play Sound
		GetComponent<AudioSource>().Play();

	}
}
