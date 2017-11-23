using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CC : MonoBehaviour {
	public Camera[] cameras;
	private int currentCameraIndex;
	// Use this for initialization

	void Start () {
		currentCameraIndex = 0;
		for (int i=1; i<cameras.Length; i++) 
		{
			cameras[i].gameObject.SetActive(false);
		}
		if (cameras.Length>0)
		{
			cameras [0].gameObject.SetActive (true);
		}
	}

	public void cc(){
		print ("hihi");
		currentCameraIndex ++;
		Debug.Log ("C button has been pressed. Switching to the next camera");
			if (currentCameraIndex < cameras.Length) {
				print (cameras [currentCameraIndex].name);
				cameras [currentCameraIndex - 1].gameObject.SetActive (false);
				cameras [currentCameraIndex].gameObject.SetActive (true);
			} else {
				cameras [currentCameraIndex - 1].gameObject.SetActive (false);
				currentCameraIndex = 0;
				cameras [currentCameraIndex].gameObject.SetActive (true);
				print (cameras [currentCameraIndex].name);
			}

	}
}
