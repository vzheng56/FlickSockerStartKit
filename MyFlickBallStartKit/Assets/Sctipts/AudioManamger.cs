using UnityEngine;
using System.Collections;

public class AudioManamger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		FlickBall_Triggers.GetBall += PlayCheersSound;
		FlickBall_Triggers.LostBall += PlayUnCheersSound;
	}

	void PlayCheersSound(){

	}


	void PlayUnCheersSound(){

	}
}
