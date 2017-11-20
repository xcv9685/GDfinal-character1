using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyHurt : MonoBehaviour {
	private Animator anim;
	GameObject Parent;
	private AnimatorStateInfo currentState;
	public float Weapondamage = 10.0f;
	private HealthUI hpUI;
	private int attackanimflag;
	private int Enemyattackanimflag;

	public ParticleSystem tpc;
	// Use this for initialization
	void Start () {
		attackanimflag = 1;
		Enemyattackanimflag = 1;
		Parent = this.gameObject;
		//print (Parent);
		for (int i = 0; i < 1000; i++) {
			Parent=Parent.gameObject.transform.parent.gameObject;
			if (Parent.tag == "Enemy" || Parent.tag == "Player"|| Parent.tag == "SwordFriend")
				break;
		}
		//print (Parent);
		tpc = gameObject.GetComponent<ParticleSystem> ();
		anim = Parent.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		currentState = anim.GetCurrentAnimatorStateInfo (0);
		if(currentState.nameHash == Animator.StringToHash ("Base Layer.Idle") )
			attackanimflag = 1; 
		if(currentState.nameHash == Animator.StringToHash ("Base Layer.knightIdle") )
			Enemyattackanimflag = 1; 
	}

	void OnCollisionEnter(Collision collider){
		if (this.tag == "PWeapon" && collider.gameObject.tag == "Enemy")  {
			currentState = anim.GetCurrentAnimatorStateInfo (0);
			if (currentState.nameHash == Animator.StringToHash ("Base Layer.Attack1")) {
				anim.SetTrigger ("Stop");
				//GameObject.Find ("ParticleManager").GetComponent<ParticleManager> ().SkillAttack1 (this.transform);
				tpc.Play();
				print ("111hit");
				if (attackanimflag == 1) {
					//this.gameObject.transform.Find("skillAttack2").gameObject.GetComponent<ParticleSystem> ().Play();
					hpUI = collider.gameObject.GetComponent<HealthUI> ();
					hpUI.OnHit (Weapondamage);
					attackanimflag = 0;
				};

			}
		}
		if (this.tag == "Weapon" && (collider.gameObject.tag == "Player" || collider.gameObject.tag == "SwordFriend")) {
			currentState = anim.GetCurrentAnimatorStateInfo (0);
			if (currentState.nameHash == Animator.StringToHash ("Base Layer.Attack1")) {
				anim.SetTrigger ("Stop");
				//GameObject.Find ("ParticleManager").GetComponent<ParticleManager> ().SkillAttack2 (this.transform);
				tpc.Play();
				if (Enemyattackanimflag == 1) {
					hpUI = collider.gameObject.GetComponent<HealthUI> ();
					hpUI.OnHit (Weapondamage);
					Enemyattackanimflag = 0;
				};

			}
		}
	}

}
