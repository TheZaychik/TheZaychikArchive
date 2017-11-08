using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ItemData2 : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {

	public Item item;
	public int amount;
	private Vector2 offset;
	public int slot_number;
	private Inventory2 inv;
	private Tooltip_1 tooltip;
	private int TR_Item_cost;
	private int PL_Item_Value;

	void Start () {
		inv = GameObject.Find ("Inventory_trading").GetComponent<Inventory2> ();
		tooltip = GameObject.Find ("Inventory_trading").GetComponent<Tooltip_1> ();
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		if (item != null) 
		{
			if (this.slot_number < 25) 
			{
				inv.TraderBlock.raycastTarget = true;
			} 
			else if (this.slot_number >= 25) 
			{
				inv.PlayerBlock.raycastTarget = true;
			}
			offset = eventData.position - new Vector2 (this.transform.position.x, this.transform.position.y);
			this.transform.position = eventData.position;
			this.transform.parent = this.transform.parent.parent.parent;
			GetComponent<CanvasGroup> ().blocksRaycasts = false;
		}
	}

	public void OnDrag (PointerEventData eventData)
	{
		if (item != null) 
		{
			this.transform.position = eventData.position - offset;
		}
	}

	public void OnEndDrag (PointerEventData eventData)
	{
		if (this.slot_number < 25) 
		{
			PL_Item_Value = 0;
			Pos_update ();
			inv.TraderBlock.raycastTarget = false;
			for (int i = 20; i < 25;i++)
			{
				PL_Item_Value = PL_Item_Value + inv.items [i].Value;
			}
			inv.Update_gold (3, PL_Item_Value);
		} 
		else if (this.slot_number >= 25) 
		{
			TR_Item_cost = 0;
			Pos_update ();
			inv.PlayerBlock.raycastTarget = false;
			for (int i = 45; i < 50;i++)
			{
				TR_Item_cost = TR_Item_cost + inv.items [i].Value;
			}
			inv.Update_gold (2, TR_Item_cost);
		}
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
		tooltip.Activate (item);
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		tooltip.Deactivate ();
	}

	public void OnPointerClick (PointerEventData eventData)
	{
	}
	private void Pos_update ()
	{
		this.transform.SetParent (inv.slots[slot_number].transform);
		this.transform.position = inv.slots [slot_number].transform.position;
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
	}

}

