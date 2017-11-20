using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warehousebackpack : MonoBehaviour {

	// Use this for initialization
	public int dragid;
	public int capacity=0;
	public props[] backpack=new props[15];
	public props[] cleanbackpack=new props[15];
	public int money;
	public int IsWarehouse = 1;
	void Start(){
		createitem();
		//this.GetComponent<UIcontroller> ().selectitemprops = backpack [0];
		money = 100;
	}
	void createitem(){
		for (int i = 0; i < 10; i++) {
			props item =  new props (Random.Range (1, 4));
			print("item");
			print (item);
			backpack [i] = item;
			item.props_ID = i;
			print("props_type:");
			print (backpack [i]);
		}
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