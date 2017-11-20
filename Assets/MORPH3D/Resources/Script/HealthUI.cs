using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour {
	public Slider HPstrip;
	public float HP=100.0f;
	public int AttackedNum;
	// Use this for initialization
	void Start () {
		HPstrip.maxValue = HP;
		HPstrip.value=HP;
	}
	void Update(){
		if (HP <= 0) {
			GameObject.Find ("ParticleManager").GetComponent<ParticleManager> ().EmissionDeadPaticle1 (this.transform);
			Destroy (this.gameObject);
		}
	}
	// Update is called once per frame
	public void OnHit (float demage) {
		HP -= demage;
		HPstrip.value=HP;
	}

}
