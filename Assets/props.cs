using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class props    {

	public string props_name;
	public string props_explain;
	public string pic_path;
	public int props_type;
	private HealthUI hp;
	public int props_ID;
	public props(int type){
		if (type == 1) {
			props_name="回復藥劑(小)";
			props_explain = "回復玩家小量生命";
			pic_path="red_potion_ic";
			props_type = 1;
		}
		else if (type == 2) {
			props_name="回復藥劑(中)";
			props_explain = "回復玩家中量生命";
			pic_path="red_potion_cone";
			props_type = 2;
		}
		else if (type == 3) {
			props_name="回復藥劑(大)";
			props_explain = "回復玩家大量生命";
			pic_path="healing_potion_but_2";
			props_type = 3;
		}
	}
	public void use(GameObject user){
		if (props_type == 1) {
			hp=user.GetComponent<HealthUI> ();
			hp.HP += 30;
		}
		else if (props_type == 2) {
			hp=user.GetComponent<HealthUI> ();
			hp.HP += 150;
			this.Destroyprops();
		}
		else if (props_type == 3) {
			hp=user.GetComponent<HealthUI> ();
			hp.HP += 300;
			this.Destroyprops();
		}
		//this = null;
	}


	public void Destroyprops(){
		//Destroy (this.gameObject);
	}
}
