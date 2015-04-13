using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	void Awake(){

	}
	// Use this for initialization
	void Start () {
		FlickBall_Triggers.GetBall += this.AddScore;
		FlickBall_Triggers.LostBall += this.MinusScore;

	}

	void OnDestroy(){
		FlickBall_Triggers.GetBall -= AddScore;
		FlickBall_Triggers.LostBall -= MinusScore;
	}

	void AddScore(){

	}
	void MinusScore(){}
}
