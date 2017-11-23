using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour {
	GameObject particle,particle1,particle2,particle3,particle4,particle5;
	// Use this for initialization

	void Start(){
		particle1 = GameObject.Instantiate (Resources.Load ("WhityBomb") as GameObject);
		particle1.SetActive (false);
		particle2 = GameObject.Instantiate (Resources.Load ("skillAttack") as GameObject);
		particle2.SetActive (false);
		particle3 = GameObject.Instantiate (Resources.Load ("SkillAttack2") as GameObject);
		particle3.SetActive (false);
		particle4 = GameObject.Instantiate (Resources.Load ("frameball") as GameObject);
		particle4.SetActive (false);
		particle5 = GameObject.Instantiate (Resources.Load ("energyblast") as GameObject);
		particle5.SetActive (false);
	}
	public void EmissionDeadPaticle1(Transform pos){
		//particle = GameObject.Instantiate (Resources.Load ("WhityBomb") as GameObject);
		particle=Instantiate(particle1,new Vector3 (pos.position.x, pos.position.y+1.2f, pos.position.z),transform.rotation);
		particle.SetActive (true);
		particle.GetComponent <ParticleSystem> ().Play ();
		/*particle1.transform.position = new Vector3 (pos.position.x, pos.position.y+1.2f, pos.position.z);
		particle1.GetComponent <ParticleSystem> ().Play ();*/
		
	}
	public void SkillAttack1(Transform pos){
		//particle = GameObject.Instantiate (Resources.Load ("skillAttack") as GameObject);
		particle=Instantiate(particle2,new Vector3 (pos.position.x, pos.position.y+1.2f, pos.position.z),transform.rotation);
		particle.SetActive (true);
		particle.GetComponent <ParticleSystem> ().Play ();
		/*particle2.transform.position = new Vector3 (pos.position.x, pos.position.y, pos.position.z)+pos.forward*2;
		particle2.GetComponent <ParticleSystem> ().Play ();*/

	}
	public void SkillAttack2(Transform pos){
		/*particle = GameObject.Instantiate (Resources.Load ("SkillAttack2") as GameObject);
		particle3.transform.position = new Vector3 (pos.position.x, pos.position.y, pos.position.z)+pos.forward;
		particle3.GetComponent <ParticleSystem> ().Play ();*/
		particle=Instantiate(particle3,new Vector3 (pos.position.x, pos.position.y+1.2f, pos.position.z),transform.rotation);
		particle.SetActive (true);
		particle.GetComponent <ParticleSystem> ().Play ();

	}
	public void MagicFrameBall(Transform pos,Vector3  enemyPos){
		/*particle = GameObject.Instantiate (Resources.Load ("frameball") as GameObject);
		particle.transform.position = new Vector3 (pos.position.x, pos.position.y+2f, pos.position.z)+pos.forward;
		print (pos.forward);*/
		particle=Instantiate(particle4,new Vector3 (pos.position.x, pos.position.y+1.2f, pos.position.z)+pos.forward*2,transform.rotation);
		particle.SetActive (true);
		//particle.GetComponent<Rigidbody> ().AddForce (pos.forward*600);
		print(enemyPos);
		print(pos.position);
		print((enemyPos - pos.position).normalized);
		particle.GetComponent<Rigidbody> ().velocity=(enemyPos - particle.transform.position).normalized * 10;


	}
	public void MagicFrameBallCollision(Transform pos){
		//particle = GameObject.Instantiate (Resources.Load ("energyblast") as GameObject);
		/*particle5.transform.position = new Vector3 (pos.position.x, pos.position.y, pos.position.z);
		particle5.GetComponent <ParticleSystem> ().Play ();*/
		particle=Instantiate(particle5,new Vector3 (pos.position.x, pos.position.y, pos.position.z),transform.rotation);
		particle.SetActive (true);
		particle.GetComponent <ParticleSystem> ().Play ();
	}
}
