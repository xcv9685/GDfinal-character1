using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class FriendDetect : MonoBehaviour {
	private GameObject enemy;
	private CharacterController cc;
	private Animator animator;
	public float detectDistance=20.5f;
	public float attackDistance = 2;
	public float attackTime = 3;
	private float attackCounter = 0;
	public float enemyspeed=1.5f;
	private Vector3 velocity;
	private Vector3 originalPosition;
	float distance;
	float finaldistance;
	public int AttackType;
	Vector3 targetPos;
	private NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		enemy = null;
		agent = GetComponent<NavMeshAgent>();
		cc = this.GetComponent<CharacterController>();
		animator = this.GetComponent<Animator> ();
		attackCounter = attackTime;
		originalPosition = transform.position;
		distance = -1;
		//enemy = findenemy (enemy);
	}

	// Update is called once per frame
	void Update () {
		if (enemy != null) {
			targetPos = enemy.transform.position;
			targetPos.y = transform.position.y;
			distance = Vector3.Distance (targetPos, transform.position);
			if (distance <= detectDistance) {
				if (distance <= attackDistance) {
					transform.LookAt (targetPos);
					attackCounter += Time.deltaTime;
					if (attackCounter > attackTime) {
						if (AttackType == 0) {
							animator.SetTrigger ("Attack");
						}
						else if (AttackType == 1) {
							animator.SetTrigger ("Attack1");
							GameObject.Find ("ParticleManager").GetComponent<ParticleManager> ().MagicFrameBall (this.transform);
						}
						attackCounter = 0;
					} else {
						agent.SetDestination (this.transform.position);
						animator.SetBool ("Walk", false);

					}
				} else {
					//enemy=findenemy (enemy);
					//print (enemy.name);
					transform.LookAt (targetPos);
					//velocity = transform.position - targetPos;
					attackCounter = attackTime;
					/*if(animator.GetCurrentAnimatorStateInfo(0).IsName("EnimyWalk"))
				cc.SimpleMove(transform.forward*speed);*/
					//transform.localPosition += -velocity.normalized * Time.fixedDeltaTime;
					agent.SetDestination (targetPos);
					//animator.speed = enemyspeed;
					animator.SetBool ("Walk", true); 
				}
			} else {
				//enemy=findenemy (enemy);
				if ((transform.position - originalPosition).sqrMagnitude > 1) {
					transform.LookAt (originalPosition);
					/*velocity = transform.position - originalPosition;
					transform.localPosition += -velocity.normalized * Time.fixedDeltaTime*3;*/
					agent.SetDestination (originalPosition);
					//animator.speed = enemyspeed;
					animator.SetBool ("Walk", true); 
				} else
					animator.SetBool ("Walk", false);
			}

		} else {
			if ((transform.position - originalPosition).sqrMagnitude > 1) {
				transform.LookAt (originalPosition);
				/*velocity = transform.position - originalPosition;
				transform.localPosition += -velocity.normalized * Time.fixedDeltaTime;*/
				//animator.speed = enemyspeed;
				agent.SetDestination (originalPosition);
				animator.SetBool ("Walk", true); 
			} else {
				agent.SetDestination (originalPosition);
				animator.SetBool ("Walk", false);
			}
			enemy=findenemy (enemy);
		}
	}
	GameObject findenemy(GameObject obj){
		GameObject[] enemyobject=GameObject.FindGameObjectsWithTag("Enemy");
		GameObject ene=obj;
		distance = -1;
		foreach (GameObject enemyobj in enemyobject) {
			if (enemyobj == obj)
				continue;
			Vector3 targetPos = enemyobj.transform.position;
			targetPos.y = transform.position.y;
			finaldistance = Vector3.Distance (targetPos, transform.position);
			if (enemyobj.gameObject.GetComponent<HealthUI> ().AttackedNum > 1)
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
		if (ene != null) {
			if (obj != null) {
				print (obj.gameObject.GetComponent<HealthUI> ().AttackedNum);
				obj.gameObject.GetComponent<HealthUI> ().AttackedNum -= 1;
			}
			ene.gameObject.GetComponent<HealthUI> ().AttackedNum += 1;
		}
		return ene;

	}
}
