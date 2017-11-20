using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backpackage : MonoBehaviour {

	// Use this for initialization
	public int dragid;
	public int capacity=0;
	public props[] backpack=new props[15];
	public props[] cleanbackpack=new props[15];
	public props[] skill = new props[4];
	public int money;
	void Start(){
		createitem();
		//this.GetComponent<UIcontroller> ().selectitemprops = backpack [0];
		money = 100;
	}
	void createitem(){
		for (int i = 0; i < 15; i++) {
			props item =  new props (Random.Range (1, 4));
			backpack [i] = item;
			item.props_ID = i;

		}
	}
	void FixedUpdate(){
		if (Input.GetButtonDown ("Skill1"))
			OnBtn0 ();
		if (Input.GetButtonDown ("Skill2"))
			OnBtn1 ();
		if (Input.GetButtonDown ("Skill3"))
			OnBtn2 ();
		if (Input.GetButtonDown ("Skill4"))
			OnBtn3 ();
	}
	public void OnBtn0(){
		if (skill [0] != null) {
			skill [0].use (this.gameObject);
			skill [0] = null;
		}
		else
			print(skill[0]);
	}
	public void OnBtn1(){
		if (skill [1] != null) {
			skill [1].use (this.gameObject);
			skill [1] = null;
		} else
			print ("skil2=null");
	}
	public void OnBtn2(){
		if (skill [2] != null) {
			skill [2].use (this.gameObject);
			skill [2] = null;
		} else
			print ("skil3=null");
	}
	public void OnBtn3(){
		if (skill [3] != null) {
			skill [3].use (this.gameObject);
			skill [3] = null;
		} else
			print ("skil4=null");
	}
	public void CleanBag(){
		print ("cleaning");
		int count = 0;
		for (int i = 0; i < 15; i++)
			cleanbackpack [i] = null;
		for (int i = 0; i < 15; i++) {
			if (backpack [i] != null) {
				cleanbackpack[count]=backpack[i];
				cleanbackpack [count].props_ID = count;
				count += 1;
			}
		}
		for (int i = 0; i < 15; i++) {
			backpack [i] = cleanbackpack [i];
			//if(backpack [i]!=null)
			//	print(i);
			//if (cleanbackpack [i] != null)
			//	print (i);
		}
	}

}
