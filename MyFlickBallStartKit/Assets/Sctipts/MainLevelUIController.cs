using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class MainLevelUIController : MonoBehaviour {

	public GameObject  startGameCavans;
	public GameObject  gameSettingCavans;

	public void StartGame(){
		startGameCavans.SetActive (false);//Model

	}

	public void GameSetting(){
		startGameCavans.SetActive (false);
		gameSettingCavans.SetActive (true);
	}

	public void OnValueChanged(float value){
		Debug.Log ("value: "+value);
	}

	public void OnTroggleValueChanged(bool flag){
		Debug.Log("flag:  "+flag);
	}

	public void QuitGame(){
		Application.Quit (); // Quit Applaction
	}



}
