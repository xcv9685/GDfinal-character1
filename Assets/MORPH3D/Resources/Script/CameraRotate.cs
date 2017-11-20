using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {
	public Transform target;
	public float x;
	public float y;
	public float xSpeed=1;
	public float ySpeed=1;
	public float distence;
	public float diSpeed=1;
	public float minDistence=1;
	public float maxDistence=5;

	private Quaternion rotationEuler;
	private Vector3 cameraPosition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		print ("hihi");
		x += Input.GetAxis ("Mouse X") * xSpeed * Time.deltaTime;
		y -= Input.GetAxis ("Mouse Y") * ySpeed * Time.deltaTime;

		if (x > 360)
			x -= 360;
		else if (x < 0)
			x += 360;

		distence -=Input.GetAxis ("Mouse ScrollWheel") * diSpeed * Time.deltaTime;
		distence = Mathf.Clamp (distence, minDistence, maxDistence);

		rotationEuler = Quaternion.Euler (y, x, 0);
		cameraPosition = rotationEuler * new Vector3 (0, 0, -distence) + target.position+ new Vector3 (0, 1.5f, -1.5f);

		transform.rotation = rotationEuler;
		transform.position = cameraPosition;
	}

	void LateUpadte()
	{
		/*print ("hihi");
		x += Input.GetAxis ("Mouse X") * xSpeed * Time.deltaTime;
		y -= Input.GetAxis ("Mouse Y") * ySpeed * Time.deltaTime;

		if (x > 360)
			x -= 360;
		else if (x < 0)
			x += 360;

		distence -=Input.GetAxis ("Mouse ScrollWheel") * diSpeed * Time.deltaTime;
		distence = Mathf.Clamp (distence, minDistence, maxDistence);

		rotationEuler = Quaternion.Euler (y, x, 0);
		cameraPosition = rotationEuler * new Vector3 (0, 0, -distence) + target.position;

		transform.rotation = rotationEuler;
		transform.position = cameraPosition;*/
	}
}
