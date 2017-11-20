using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WarehouseDropMe : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
	public Image containerImage;
	public Image receivingImage;
	public int bagid;
	public props selectitemprops;
	private Color normalColor;
	public Color highlightColor = Color.yellow;
	private int cross;

	public void OnEnable ()
	{
		if (containerImage != null) {
			print ("1");
			normalColor = containerImage.color;
		}
		print ("2");
	}

	public void OnDrop(PointerEventData data)
	{
		print (data.pointerDrag.transform.parent.parent.parent.parent.tag);
		containerImage.color = normalColor;
		if (receivingImage == null)
			return;

		Sprite dropSprite = GetDropSprite (data);
		if (dropSprite != null) {
			print ("3");
			//receivingImage.sprite = dropSprite;
			if (cross == 0) {
				if (this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid] != null && data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().dragid] != null) {
					selectitemprops = this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid];
					int id = data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().dragid;
					print (selectitemprops.props_ID);
					this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid] = data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().dragid];
					this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid].props_ID = bagid;
					data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().dragid] = selectitemprops;
					data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().dragid].props_ID = id;
				} else if (this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid] == null && data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().dragid] != null) {
					this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid] = data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().dragid];
					this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid].props_ID = bagid;
					data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().dragid] = null;
				}
			} else if (cross == 1) {
				if (this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid] != null && data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<backpackage> ().backpack [data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<backpackage> ().dragid] != null) {
					selectitemprops = this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid];
					int id = data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<backpackage> ().dragid;
					print (selectitemprops.props_ID);
					this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid] = data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<backpackage> ().backpack [data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<backpackage> ().dragid];
					this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid].props_ID = bagid;
					data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<backpackage> ().backpack [data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<backpackage> ().dragid] = selectitemprops;
					data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<backpackage> ().backpack [data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<backpackage> ().dragid].props_ID = id;
				}else if (this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid] == null && data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<backpackage> ().backpack [data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<backpackage> ().dragid] != null) {
					this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid] = data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<backpackage> ().backpack [data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<backpackage> ().dragid];
					this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid].props_ID = bagid;
					data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<backpackage> ().backpack [data.pointerDrag.transform.parent.parent.parent.parent.gameObject.GetComponent<backpackage> ().dragid] = null;
				}
				}
			}
			/*if (this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid] != null && this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().dragid] != null) {
				selectitemprops = this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid];
				int id = this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().dragid;
				print (selectitemprops.props_ID);
				this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid] = this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().dragid];
				this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid].props_ID = bagid;
				this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().dragid] = selectitemprops;
				this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().dragid].props_ID = id;
			} else if(this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid] == null && this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().dragid] != null){
				this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid] = this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().dragid];
				this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [bagid].props_ID = bagid;
				this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().backpack [this.transform.parent.parent.parent.parent.gameObject.GetComponent<Warehousebackpack> ().dragid] = null;
			}*/


	}

	public void OnPointerEnter(PointerEventData data)
	{
		print ("4");
		if (containerImage == null)
			return;

		Sprite dropSprite = GetDropSprite (data);
		if (dropSprite != null)
			containerImage.color = highlightColor;
	}

	public void OnPointerExit(PointerEventData data)
	{
		if (containerImage == null)
			return;

		containerImage.color = normalColor;
	}

	private Sprite GetDropSprite(PointerEventData data)
	{
		var originalObj = data.pointerDrag;
		if (originalObj == null)
			return null;

		var dragMe = originalObj.GetComponent<DragMe>();
		var warehousedragMe = originalObj.GetComponent<WarehouseDragMe>();
		if (dragMe == null && warehousedragMe != null)
			cross = 0;
		else if (dragMe != null && warehousedragMe == null)
			cross = 1;
		else if (dragMe == null && warehousedragMe==null)
			return null;

		var srcImage = originalObj.GetComponent<Image>();
		if (srcImage == null)
			return null;
		print ("here");
		return srcImage.sprite;
	}
}
