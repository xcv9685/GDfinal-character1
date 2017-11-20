using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {
	float timer= 0f;
	GameObject enemyspawn;
	public int maxcount;
	private int count;
	// Use this for initialization
	void Start () {
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		print (timer);
		if (timer > 3f && count<=maxcount) {
			enemyspawn = GameObject.Instantiate (Resources.Load ("knightprefab-maul") as GameObject);
			enemyspawn.transform.position = this.transform.position;
			//enemyspawn.transform.position = new Vector3(1f,-0.9833f,1f);
			timer = 0;
			count += 1;
			print ("inin");
		}
	}
}
