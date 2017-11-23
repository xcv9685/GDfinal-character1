using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warehouse : MonoBehaviour {
	private GameObject canvas,wcanv,bagcanv;
	private Collider coll;
	void Start(){
		canvas=transform.Find("WarehouseBtnCanvas").gameObject;
		wcanv = transform.Find ("WarehouseCanvas").gameObject;
	}
	void Update(){
		if (Input.GetButtonDown ("open") && canvas.activeSelf==true)
			WarehouseBtn ();
		if (Input.GetKeyDown (KeyCode.Escape) && wcanv.activeSelf) {
			WarehouseCancelBtn ();
		}
	}
	// Use this for initialization
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			coll = other;
			print ("collide");
			canvas.SetActive (true);
		}
	}
	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "Player") {
			canvas.SetActive (false);
			wcanv.SetActive (false);
			coll.GetComponent<UIcontroller> ().BagCancelBtn ();
		}
	}
	public void WarehouseBtn(){
		if (!wcanv.activeSelf) {
			print (coll.tag);
			coll.GetComponent<UIcontroller> ().BackpackBtn ();
			wcanv.SetActive (true);
		} else {
			coll.GetComponent<UIcontroller> ().BagCancelBtn ();
			wcanv.SetActive (false);
		}

	}
	public void WarehouseCancelBtn(){
		wcanv.SetActive (false);

	}
}
