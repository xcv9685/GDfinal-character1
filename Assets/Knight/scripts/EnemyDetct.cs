using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyDetct : MonoBehaviour {
	private GameObject player;
	private CharacterController cc;
	private Animator animator;
	public float detectDistance=20.5f;
	public float attackDistance = 2;
	public float attackTime = 3;
	private float attackCounter = 0;
	public float enemyspeed=1.5f;
	private Vector3 velocity;
	private Vector3 originalPosition;
	private NavMeshAgent agent;
	float distance;
	float finaldistance;
	// Use this for initialization
	void Start () {
		//player = null;
		player = GameObject.FindGameObjectWithTag("Player");
		cc = this.GetComponent<CharacterController>();
		animator = this.GetComponent<Animator> ();
		attackCounter = attackTime;
		originalPosition = transform.position;
		agent = GetComponent<NavMeshAgent>();
		agent.enabled = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (player != null) {
			Vector3 targetPos = player.transform.position;
			targetPos.y = transform.position.y;
			float distance = Vector3.Distance (targetPos, transform.position);
			if (distance <= detectDistance) {
				print("<detect");
				if (distance <= attackDistance) {
					agent.SetDestination (this.transform.position);
					transform.LookAt (targetPos);
					attackCounter += Time.deltaTime;
					if (attackCounter > attackTime) {
						animator.SetTrigger ("Attack");
						attackCounter = 0;
					} else {
						agent.SetDestination (this.transform.position);
						animator.SetBool ("Walk", false);

					}
				} else {
					player = findenemy (player);
					//targetPos = player.transform.position;
					animator.SetBool ("Walk", true);
					agent.SetDestination (targetPos);
					transform.LookAt (targetPos);
					print ("hhhh");
					attackCounter = attackTime;

					animator.SetBool ("Walk", true); 
				}
			} else {
				print(">detect");
				//player = GameObject.FindGameObjectWithTag("Player");
				player = findenemy (player);
				animator.SetBool ("Walk", true);
				agent.SetDestination (targetPos);
			}
		} else {
			player = findenemy (player);
			if(player==null)
				player = GameObject.FindGameObjectWithTag("Player");
		}
		
	}
	GameObject findenemy(GameObject obj){
		print ("in findenemy");
		GameObject[] enemyobject=GameObject.FindGameObjectsWithTag("SwordFriend");
		GameObject ene=obj;
		distance = -1;
		foreach (GameObject enemyobj in enemyobject) {
			print (enemyobj.name);
			Vector3 targetPos = enemyobj.transform.position;
			targetPos.y = transform.position.y;
			finaldistance = Vector3.Distance (targetPos, transform.position);
			if (enemyobj.gameObject.GetComponent<HealthUI> ().AttackedNum >= 1)
				finaldistance *= enemyobj.gameObject.GetComponent<HealthUI> ().AttackedNum;
			if (distance == -1) {
				distance = finaldistance;
				ene = enemyobj;
			}
			else if (finaldistance < distance) {
				distance = finaldistance;
				ene = enemyobj;
			}
		}
		if (ene != obj) {
			ene.gameObject.GetComponent<HealthUI> ().AttackedNum += 1;
			if(obj!=null)
				obj.gameObject.GetComponent<HealthUI> ().AttackedNum -= 1;
		}
		return ene;

	}
}
