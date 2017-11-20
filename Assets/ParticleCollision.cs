using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour {
	private HealthUI hpUI;
	public float Weapondamage = 30.0f;
	GameObject Parent;
	void OnCollisionEnter(Collision collider)
	{
		//print ( collider.gameObject.name);
		if (collider.gameObject.tag == "Weapon") {
			Parent = collider.gameObject;
			for (int i = 0; i < 1000; i++) {
				Parent=Parent.gameObject.transform.parent.gameObject;
				if (Parent.tag == "Enemy" || Parent.tag == "Player"|| Parent.tag == "SwordFriend")
					break;
			}
			print (Parent);
			Destroy (this.gameObject);
			GameObject.Find ("ParticleManager").GetComponent<ParticleManager> ().MagicFrameBallCollision (this.transform);
			hpUI = Parent.gameObject.GetComponent<HealthUI> ();
			hpUI.OnHit (Weapondamage);

		}
		else if (collider.gameObject.tag != "Player" && collider.gameObject.tag != "PWeapon" && collider.gameObject.tag != "SwordFriend" /*&& collider.gameObject.tag != "Weapon"*/) {
			print ("hoho");
			print (collider.gameObject.name);
			Destroy (this.gameObject);
			GameObject.Find ("ParticleManager").GetComponent<ParticleManager> ().MagicFrameBallCollision (this.transform);
			if (collider.gameObject.tag == "Enemy") {
				hpUI = collider.gameObject.GetComponent<HealthUI> ();
				hpUI.OnHit (Weapondamage);
			}
		} 
	}
	void OnParticleCollision(GameObject collider)
	{
		if (collider.gameObject.tag != "Player" && collider.gameObject.tag != "PWeapon"&& collider.gameObject.tag != "SwordFriend" && collider.gameObject.tag != "Weapon") {
			print (collider.gameObject.name);
			Destroy (this.gameObject);
			GameObject.Find ("ParticleManager").GetComponent<ParticleManager> ().MagicFrameBallCollision (this.transform);
			if (collider.gameObject.tag == "Enemy") {
				hpUI = collider.gameObject.GetComponent<HealthUI> ();
				hpUI.OnHit (Weapondamage);
			}
		}
	}
}
