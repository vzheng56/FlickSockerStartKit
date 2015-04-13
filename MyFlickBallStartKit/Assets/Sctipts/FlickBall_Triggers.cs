using UnityEngine;
using System.Collections;

public class FlickBall_Triggers : MonoBehaviour {

	//定义事件

	public delegate void BallEventHandle();

	public static event BallEventHandle GetBall;
	public static event BallEventHandle LostBall;

	void OnTriggerEnter(Collider other)
	{

		if (gameObject.tag == "GetBall") {
			if(GetBall!=null) GetBall ();
		} else {
			if(LostBall!=null) LostBall();
		}
	}

}
