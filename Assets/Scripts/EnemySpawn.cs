using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {
	float timer= 0f;
	GameObject enemyspawn;
	public int maxcount;
	private int count;
	private int start=0;
	// Use this for initialization
	void Start () {
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= 30.0f) {
			start = 1;
			timer = 0.0f;
		}
		if (timer > 3f && count<=maxcount && start==1) {
			enemyspawn = GameObject.Instantiate (Resources.Load ("knightprefab-maul") as GameObject);
			enemyspawn.transform.position = this.transform.position;
			//enemyspawn.transform.position = new Vector3(160.0f,-0.9833f,50.0f);
			timer = 0;
			count += 1;
		}
	}
}
