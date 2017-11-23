using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllRoom : MonoBehaviour {
	private GameObject player,camview;
	CC ccview;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("open") && transform.Find("ControllRoomBtnCanvas").gameObject.activeSelf==true)
			InControllRoom ();
	}
		

	public void InControllRoom(){
		camview = player.transform.Find ("CameraCanvas").gameObject;
		transform.Find("ControllRoomBtnCanvas").gameObject.SetActive (false);
		camview.GetComponent<CC> ().cameras [2].gameObject.SetActive (true);
		camview.GetComponent<CC> ().cameras [0].gameObject.SetActive (false);
		camview.GetComponent<CC> ().cameras [1].gameObject.SetActive (false);

	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			transform.Find("ControllRoomBtnCanvas").gameObject.SetActive (true);
		}
	}
	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "Player") {
			transform.Find("ControllRoomBtnCanvas").gameObject.SetActive (false);
			camview.GetComponent<CC> ().cameras [2].gameObject.SetActive (false);
			camview.GetComponent<CC> ().cameras [0].gameObject.SetActive (true);
			camview.GetComponent<CC> ().cameras [1].gameObject.SetActive (false);
		}
	}
}
