using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	static int idleState = Animator.StringToHash("Base Layer.Idle");
	static int locoState = Animator.StringToHash("Base Layer.Locomotion");
	//static int jumpState = Animator.StringToHash("Base Layer.Jump");
	static int restState = Animator.StringToHash("Base Layer.Rest");

	public float animSpeed = 1.5f;		
	public float forwardSpeed = 7.0f;
	public float backwardSpeed = 2.0f;
	public float rotateSpeed = 2.0f;


	private Animator anim;
	private AnimatorStateInfo currentState;
	private CapsuleCollider col;
	private Rigidbody rb;
	private Vector3 velocity;
	private float orgColHight;
	private Vector3 orgVectColCenter;


	GameObject Magical;
	int MagicAttackFlag;


	void Start () {
		anim = GetComponent<Animator>();
		col = GetComponent<CapsuleCollider>();
		rb = GetComponent<Rigidbody>();
		orgColHight = col.height;
		orgVectColCenter = col.center;
		MagicAttackFlag = 1;
	}
	
	// Update is called once per frame
	void Update () {
		/*currentState = anim.GetCurrentAnimatorStateInfo (0);
		if (currentState.IsName ("Base Layer.Attack2") && currentState.) {
			MagicAttackFlag = 1;
			print("Magical finish");
		}*/
	}
	void FixedUpdate ()
	{
		currentState = anim.GetCurrentAnimatorStateInfo (0);
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		anim.SetFloat ("Speed", v);	
		anim.SetFloat ("Direction", h); 
		anim.speed = animSpeed;								
		rb.useGravity = true;

		velocity = new Vector3(0, 0, v);		
		velocity = transform.TransformDirection(velocity);

		if (v > 0.1) {
			velocity *= forwardSpeed;		
		} else if (v < -0.1) {
			velocity *= backwardSpeed;	
		}
		if(Input.GetButtonDown ("Fire1")){
			anim.SetBool ("Attack", true);

		}
		else
			anim.SetBool ("Attack", false);
		if (Input.GetButtonDown ("MagicAttack") ) {
			anim.SetBool ("Attack2",true);

		}
		else
			anim.SetBool ("Attack2",false);
		if (!currentState.IsName ("Attack1") && !currentState.IsName ("Attack2")) {
			transform.localPosition += velocity * Time.fixedDeltaTime;

			transform.Rotate (0, h * rotateSpeed, 0);
		}

		if (currentState.IsName ("Idle") || currentState.IsName ("Locomotion") || currentState.IsName ("WalkBack")) {
			MagicAttackFlag = 1;
		}
		if (currentState.IsName ("Attack2") && MagicAttackFlag == 1) {
			GameObject.Find ("ParticleManager").GetComponent<ParticleManager> ().MagicFrameBall (this.transform);
			MagicAttackFlag = 0;
		}
	}
}
