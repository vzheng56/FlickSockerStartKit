using UnityEngine;
using System.Collections;

public class CameraRay : MonoBehaviour {


	// Update is called once per frame
	void Update () {

		Ray camRay = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit cameraHit;

		if (Physics.Raycast (camRay, out cameraHit,1000)) {

			Debug.Log(cameraHit.collider.gameObject.name);
		}
	
	}
}
