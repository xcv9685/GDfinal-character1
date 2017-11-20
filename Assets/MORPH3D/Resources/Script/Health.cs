using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
	//private Animator anim;	
	private Animator anim;
	private AnimatorStateInfo currentState;
	public float Attackdamage = 10.0f;
	private HealthUI hpUI;
	// Use this for initialization
	void Start () {
		//hpUI = GetComponent<HealthUI>();
		//anim = GetComponent<Animator>();
	}
		
	// Update is called once per frame
	void Update () {
	}
	/*void OnCollisionEnter(Collision collider)
	{
		if (collider.gameObject.tag == "PWeapon" && this.gameObject.tag!="Player") {
			anim = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();
			currentState = anim.GetCurrentAnimatorStateInfo(0);
			if (currentState.nameHash == Animator.StringToHash ("Base Layer.Attack1")) {
				hpUI.OnHit (Attackdamage);
				//print (hpUI.HP);
			}
			//anim.SetTrigger ("Hurt");
		}
	}*/


}
