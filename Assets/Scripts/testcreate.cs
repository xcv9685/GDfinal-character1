using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class testcreate : MonoBehaviour {
	public Transform target;
	private NavMeshAgent agent;
	private Animator anim;
	private Transform origin;
	private Vector3 targetc;
	int findingpath;
	GameObject player;
	//public MazeGenerator maz;
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		anim = GetComponent<Animator>();
		origin = this.transform;
		player = GameObject.FindWithTag ("Player");
		//targetc = new Vector3 (Random.Range (0, 30)*10, this.transform.position.y, Random.Range (0, 30)*10);
		targetc = new Vector3 (player.transform.position.x, this.transform.position.y, player.transform.position.z);
		findingpath = 1;
		print (targetc);
	}
	void Update () {
		origin = this.transform;
		if (findingpath == 1) {
			anim.SetBool ("Walk", true);
			agent.SetDestination (targetc);
			findingpath = 0;
		}

		if (origin.position == new Vector3 (targetc.x, origin.position.y, targetc.z)) {
			targetc = new Vector3 (Random.Range (0, 30) * 10, this.transform.position.y, Random.Range (0, 30) * 10);
			print ("arrive");
			print (targetc);
			findingpath = 1;
		}
	}

}
