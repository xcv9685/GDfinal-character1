using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WarehouseUIcontroller : MonoBehaviour {

	private GameObject canv,bagcanv,moneyIm,infocanv;
	private GameObject pack1,pack2,pack3,pack4,pack5,pack6,pack7,pack8,pack9,pack10,pack11,pack12,pack13,pack14,pack15;
	private GameObject packimg1,packimg2,packimg3,packimg4,packimg5,packimg6,packimg7,packimg8,packimg9,packimg10,packimg11,packimg12,packimg13,packimg14,packimg15;
	private GameObject skill1,skill2,skill3,skill4,bag;
	private Image img1,img2,img3,img4;
	private Image backimg1,backimg2,backimg3,backimg4,backimg5,backimg6,backimg7,backimg8,backimg9,backimg10,backimg11,backimg12,backimg13,backimg14,backimg15;
	private Image pbackimg1,pbackimg2,pbackimg3,pbackimg4,pbackimg5,pbackimg6,pbackimg7,pbackimg8,pbackimg9,pbackimg10,pbackimg11,pbackimg12,pbackimg13,pbackimg14,pbackimg15;
	private int selectitem;
	public props selectitemprops;
	private Text mon,hp,mp,attack,attackspeed,speed;
	// Use this for initialization
	void Start () {
		selectitem = 100;
		bagcanv = transform.Find("WarehouseCanvas").gameObject;
		bag = bagcanv.transform.Find ("Bag").gameObject;
		moneyIm = bag.transform.Find("Money").gameObject;
		mon=moneyIm.transform.Find("Text").gameObject.GetComponent<Text> ();
		pack1 = bag.transform.Find ("Pack1").gameObject;
		pack2 = bag.transform.Find ("Pack2").gameObject;
		pack3 = bag.transform.Find ("Pack3").gameObject;
		pack4 = bag.transform.Find ("Pack4").gameObject;
		pack5 = bag.transform.Find ("Pack5").gameObject;
		pack6 = bag.transform.Find ("Pack6").gameObject;
		pack7 = bag.transform.Find ("Pack7").gameObject;
		pack8 = bag.transform.Find ("Pack8").gameObject;
		pack9 = bag.transform.Find ("Pack9").gameObject;
		pack10 = bag.transform.Find ("Pack10").gameObject;
		pack11 = bag.transform.Find ("Pack11").gameObject;
		pack12 = bag.transform.Find ("Pack12").gameObject;
		pack13 = bag.transform.Find ("Pack13").gameObject;
		pack14 = bag.transform.Find ("Pack14").gameObject;
		pack15 = bag.transform.Find ("Pack15").gameObject;
		packimg1 = pack1.transform.Find ("back1").gameObject;
		packimg2 = pack2.transform.Find ("back2").gameObject;
		packimg3 = pack3.transform.Find ("back3").gameObject;
		packimg4 = pack4.transform.Find ("back4").gameObject;
		packimg5 = pack5.transform.Find ("back5").gameObject;
		packimg6 = pack6.transform.Find ("back6").gameObject;
		packimg7 = pack7.transform.Find ("back7").gameObject;
		packimg8 = pack8.transform.Find ("back8").gameObject;
		packimg9 = pack9.transform.Find ("back9").gameObject;
		packimg10 = pack10.transform.Find ("back10").gameObject;
		packimg11 = pack11.transform.Find ("back11").gameObject;
		packimg12 = pack12.transform.Find ("back12").gameObject;
		packimg13 = pack13.transform.Find ("back13").gameObject;
		packimg14 = pack14.transform.Find ("back14").gameObject;
		packimg15 = pack15.transform.Find ("back15").gameObject;
		backimg1 = packimg1.GetComponent<Image> ();
		backimg2 = packimg2.GetComponent<Image> ();
		backimg3 = packimg3.GetComponent<Image> ();
		backimg4 = packimg4.GetComponent<Image> ();
		backimg5 = packimg5.GetComponent<Image> ();
		backimg6 = packimg6.GetComponent<Image> ();
		backimg7 = packimg7.GetComponent<Image> ();
		backimg8 = packimg8.GetComponent<Image> ();
		backimg9 = packimg9.GetComponent<Image> ();
		backimg10 = packimg10.GetComponent<Image> ();
		backimg11 = packimg11.GetComponent<Image> ();
		backimg12 = packimg12.GetComponent<Image> ();
		backimg13 = packimg13.GetComponent<Image> ();
		backimg14 = packimg14.GetComponent<Image> ();
		backimg15 = packimg15.GetComponent<Image> ();
		pbackimg1 = pack1.GetComponent<Image> ();
		pbackimg2 = pack2.GetComponent<Image> ();
		pbackimg3 = pack3.GetComponent<Image> ();
		pbackimg4 = pack4.GetComponent<Image> ();
		pbackimg5 = pack5.GetComponent<Image> ();
		pbackimg6 = pack6.GetComponent<Image> ();
		pbackimg7 = pack7.GetComponent<Image> ();
		pbackimg8 = pack8.GetComponent<Image> ();
		pbackimg9 = pack9.GetComponent<Image> ();
		pbackimg10 = pack10.GetComponent<Image> ();
		pbackimg11 = pack11.GetComponent<Image> ();
		pbackimg12 = pack12.GetComponent<Image> ();
		pbackimg13 = pack13.GetComponent<Image> ();
		pbackimg14 = pack14.GetComponent<Image> ();
		pbackimg15 = pack15.GetComponent<Image> ();



		//img.overrideSprite = Resources.Load ("Area730/Ultimate Game UI/Sliced/SHOP/sword_ic", typeof(Sprite))as Sprite;
	}

	// Update is called once per frame
	void Update () {
		if (selectitem != 100)
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [selectitem-1];

		mon.text = this.GetComponent<Warehousebackpack> ().money.ToString();

		if(selectitem==1 ) {
			pbackimg1.sprite = Resources.Load ("opened_level", typeof(Sprite))as Sprite;
		}
		else
			pbackimg1.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
		if (this.GetComponent<Warehousebackpack> ().backpack [0] != null) {
			backimg1.sprite = Resources.Load (this.GetComponent<Warehousebackpack> ().backpack [0].pic_path, typeof(Sprite))as Sprite;
			backimg1.fillAmount = 1;
		} else {
			backimg1.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
			backimg1.fillAmount = 0;
		}
		if(selectitem==2 ) {
			pbackimg2.sprite = Resources.Load ("opened_level", typeof(Sprite))as Sprite;
		}
		else
			pbackimg2.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
		if (this.GetComponent<Warehousebackpack> ().backpack [1] != null) {
			backimg2.sprite = Resources.Load (this.GetComponent<Warehousebackpack> ().backpack [1].pic_path, typeof(Sprite))as Sprite;
			backimg2.fillAmount = 1;
		}
		else {
			backimg2.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
			backimg2.fillAmount = 0;
		}

		if(selectitem==3 ) {
			pbackimg3.sprite = Resources.Load ("opened_level", typeof(Sprite))as Sprite;
		}
		else
			pbackimg3.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
		if (this.GetComponent<Warehousebackpack> ().backpack [2] != null) {
			backimg3.sprite = Resources.Load (this.GetComponent<Warehousebackpack> ().backpack [2].pic_path, typeof(Sprite))as Sprite;
			backimg3.fillAmount = 1;
		}
		else {
			backimg3.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
			backimg3.fillAmount = 0;
		}

		if(selectitem==4 ) {
			pbackimg4.sprite = Resources.Load ("opened_level", typeof(Sprite))as Sprite;
		}
		else
			pbackimg4.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
		if (this.GetComponent<Warehousebackpack> ().backpack [3] != null) {
			backimg4.sprite = Resources.Load (this.GetComponent<Warehousebackpack> ().backpack [3].pic_path, typeof(Sprite))as Sprite;
			backimg4.fillAmount = 1;
		}
		else{
			backimg4.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
			backimg4.fillAmount = 0;
		}

		if(selectitem==5 ) {
			pbackimg5.sprite = Resources.Load ("opened_level", typeof(Sprite))as Sprite;
		}
		else
			pbackimg5.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
		if (this.GetComponent<Warehousebackpack> ().backpack [4] != null) {
			backimg5.sprite = Resources.Load (this.GetComponent<Warehousebackpack> ().backpack [4].pic_path, typeof(Sprite))as Sprite;
			backimg5.fillAmount = 1;
		}
		else{
			backimg5.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
			backimg5.fillAmount = 0;
		}

		if(selectitem==6 ) {
			pbackimg6.sprite = Resources.Load ("opened_level", typeof(Sprite))as Sprite;
		}
		else
			pbackimg6.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
		if (this.GetComponent<Warehousebackpack> ().backpack [5] != null) {
			backimg6.sprite = Resources.Load (this.GetComponent<Warehousebackpack> ().backpack [5].pic_path, typeof(Sprite))as Sprite;
			backimg6.fillAmount = 1;
		}
		else{
			backimg6.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
			backimg6.fillAmount = 0;
		}

		if(selectitem==7 ) {
			pbackimg7.sprite = Resources.Load ("opened_level", typeof(Sprite))as Sprite;
		}
		else
			pbackimg7.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
		if (this.GetComponent<Warehousebackpack> ().backpack [6] != null) {
			backimg7.sprite = Resources.Load (this.GetComponent<Warehousebackpack> ().backpack [6].pic_path, typeof(Sprite))as Sprite;
			backimg7.fillAmount = 1;
		}
		else{
			backimg7.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
			backimg7.fillAmount = 0;
		}

		if(selectitem==8 ) {
			pbackimg8.sprite = Resources.Load ("opened_level", typeof(Sprite))as Sprite;
		}
		else
			pbackimg8.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
		if (this.GetComponent<Warehousebackpack> ().backpack [7] != null) {
			backimg8.sprite = Resources.Load (this.GetComponent<Warehousebackpack> ().backpack [7].pic_path, typeof(Sprite))as Sprite;
			backimg8.fillAmount = 1;
		}
		else{
			backimg8.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
			backimg8.fillAmount = 0;
		}

		if(selectitem==9 ) {
			pbackimg9.sprite = Resources.Load ("opened_level", typeof(Sprite))as Sprite;
		}
		else
			pbackimg9.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
		if (this.GetComponent<Warehousebackpack> ().backpack [8] != null) {
			backimg9.sprite = Resources.Load (this.GetComponent<Warehousebackpack> ().backpack [8].pic_path, typeof(Sprite))as Sprite;
			backimg9.fillAmount = 1;
		}
		else{
			backimg9.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
			backimg9.fillAmount = 0;
		}

		if(selectitem==10 ) {
			pbackimg10.sprite = Resources.Load ("opened_level", typeof(Sprite))as Sprite;
		}
		else 
			pbackimg10.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
		if (this.GetComponent<Warehousebackpack> ().backpack [9] != null) {
			backimg10.sprite = Resources.Load (this.GetComponent<Warehousebackpack> ().backpack [9].pic_path, typeof(Sprite))as Sprite;
			backimg10.fillAmount = 1;
		}
		else{
			backimg10.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
			backimg10.fillAmount = 0;
		}

		if(selectitem==11 ) {
			pbackimg11.sprite = Resources.Load ("opened_level", typeof(Sprite))as Sprite;
		}
		else
			pbackimg11.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
		if (this.GetComponent<Warehousebackpack> ().backpack [10] != null) {
			backimg11.sprite = Resources.Load (this.GetComponent<Warehousebackpack> ().backpack [10].pic_path, typeof(Sprite))as Sprite;
			backimg11.fillAmount = 1;
		}
		else{
			backimg11.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
			backimg11.fillAmount = 0;
		}
		if(selectitem==12 ) {
			pbackimg12.sprite = Resources.Load ("opened_level", typeof(Sprite))as Sprite;
		}
		else
			pbackimg12.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
		if (this.GetComponent<Warehousebackpack> ().backpack [11] != null) {
			backimg12.sprite = Resources.Load (this.GetComponent<Warehousebackpack> ().backpack [11].pic_path, typeof(Sprite))as Sprite;
			backimg12.fillAmount = 1;
		}
		else{
			backimg12.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
			backimg12.fillAmount = 0;
		}

		if(selectitem==13 ) {
			pbackimg13.sprite = Resources.Load ("opened_level", typeof(Sprite))as Sprite;
		}
		else
			pbackimg13.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
		if (this.GetComponent<Warehousebackpack> ().backpack [12] != null) {
			backimg13.sprite = Resources.Load (this.GetComponent<Warehousebackpack> ().backpack [12].pic_path, typeof(Sprite))as Sprite;
			backimg13.fillAmount = 1;
		}
		else{
			backimg13.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
			backimg13.fillAmount = 0;
		}


		if(selectitem==14 ) {
			pbackimg14.sprite = Resources.Load ("opened_level", typeof(Sprite))as Sprite;
		}
		else
			pbackimg14.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
		if (this.GetComponent<Warehousebackpack> ().backpack [13] != null) {
			backimg14.sprite = Resources.Load (this.GetComponent<Warehousebackpack> ().backpack [13].pic_path, typeof(Sprite))as Sprite;
			backimg14.fillAmount = 1;
		}
		else{
			backimg14.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
			backimg14.fillAmount = 0;
		}

		if(selectitem==15 ) {
			pbackimg15.sprite = Resources.Load ("opened_level", typeof(Sprite))as Sprite;
		}
		else
			pbackimg15.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
		if (this.GetComponent<Warehousebackpack> ().backpack [14] != null) {
			backimg15.sprite = Resources.Load (this.GetComponent<Warehousebackpack> ().backpack [14].pic_path, typeof(Sprite))as Sprite;
			backimg15.fillAmount = 1;
			//packimg15.SetActive (true);
		} else {
			backimg15.sprite = Resources.Load ("orange_frame", typeof(Sprite))as Sprite;
			backimg15.fillAmount = 0;
			//packimg15.SetActive (false);
		}
	}


	public void ItemSelect(GameObject item){
		if (item.name == "Pack1") {
			selectitem = 1;
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [0];
			//print (selectitemprops);
		}
		else if (item.name == "Pack2")
		{
			selectitem = 2;
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [1];
			//print (selectitemprops);
		}
		else if (item.name == "Pack3")
		{
			selectitem = 3;
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [2];
			//print (selectitemprops);
		}
		else if (item.name == "Pack4")
		{
			selectitem = 4;
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [3];
			//print (selectitemprops);
		}
		else if (item.name == "Pack5")
		{
			selectitem = 5;
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [4];
			//print (selectitemprops);
		}
		else if (item.name == "Pack6")
		{
			selectitem = 6;
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [5];
			//print (selectitemprops);
		}
		else if (item.name == "Pack7")
		{
			selectitem = 7;
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [6];
			//print (selectitemprops);
		}
		else if (item.name == "Pack8")
		{
			selectitem = 8;
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [7];
			//print (selectitemprops);
		}
		else if (item.name == "Pack9")
		{
			selectitem = 9;
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [8];
			//print (selectitemprops);
		}
		else if (item.name == "Pack10")
		{
			selectitem = 10;
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [9];
			//print (selectitemprops);
		}
		else if (item.name == "Pack11")
		{
			selectitem = 11;
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [10];
			//print (selectitemprops);
		}
		else if (item.name == "Pack12")
		{
			selectitem = 12;
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [11];
			//print (selectitemprops);
		}
		else if (item.name == "Pack13")
		{
			selectitem = 13;
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [12];
			//print (selectitemprops);
		}
		else if (item.name == "Pack14")
		{
			selectitem = 14;
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [13];
			//print (selectitemprops);
		}
		else if (item.name == "Pack15")
		{
			selectitem = 15;
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [14];

		}

	}
	public void DropBtn(){
		if (selectitemprops != null) {
			this.GetComponent<Warehousebackpack> ().backpack [selectitemprops.props_ID] = null;
			selectitemprops = null;
		}
	}

	public void Clean(){
		for (int i = 0; i < 15; i++) {
			if (this.GetComponent<Warehousebackpack> ().backpack [i] != null)
				print (this.GetComponent<Warehousebackpack> ().backpack [i].props_ID);
			else
				print ("null");
		}
		this.GetComponent<Warehousebackpack> ().CleanBag ();
		if (selectitem==1)
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [0];
		else if (selectitem==2)
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [1];
		else if (selectitem==3)
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [2];
		else if (selectitem==4)
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [3];
		else if (selectitem==5)
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [4];
		else if (selectitem==6)
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [5];
		else if (selectitem==7)
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [6];
		else if (selectitem==8)
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [7];
		else if (selectitem==9)
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [8];
		else if (selectitem==10)
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [9];
		else if (selectitem==11)
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [10];
		else if (selectitem==12)
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [11];
		else if (selectitem==13)
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [12];
		else if (selectitem==14)
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [13];
		else if (selectitem==15)
			selectitemprops = this.GetComponent<Warehousebackpack> ().backpack [14];


	}
}