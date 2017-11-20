using UnityEngine;
using System.Collections;

public class Minimap : MonoBehaviour {

	public Transform target; // 之後要把第一人稱控制器丟入這裡
	//public Transform depthPlane; // 之後要把遮罩平面丟入 Plane 這裡
	//Camera cam;

	void Start () {
		//cam = GetComponent<Camera>();
	}

	void Update () {
		transform.position = new Vector3(target.position.x , 10, target.position.z);
		//cam.pixelRect = new Rect(0, 0, 200, 200);
		//depthPlane.localScale = new Vector3(cam.orthographicSize, cam.orthographicSize, cam.orthographicSize);
	}
}