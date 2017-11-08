using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemData : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {

	public Item item;
	public int amount;
	private Vector2 offset;
	public int slot_number;
	private Inventory inv;
	private Tooltip tooltip;
	private Transform previous_parent_slot;
	private int previous_slot_number;
	private Image HeadBlock;
	private Image HandBlock;
	private Image TorsoBlock;
	private Image LegsBlock;
	private Image FeetBlock;

	void Start () {
		HeadBlock = GameObject.Find ("HeadBlock").GetComponent<Image> ();
		HandBlock = GameObject.Find ("HandsBlock").GetComponent<Image> ();
		TorsoBlock = GameObject.Find ("TorsoBlock").GetComponent<Image> ();
		LegsBlock = GameObject.Find ("LegsBlock").GetComponent<Image> ();
		FeetBlock = GameObject.Find ("FeetBlock").GetComponent<Image> ();
		inv = GameObject.Find ("Inventory").GetComponent<Inventory> ();
		tooltip = inv.GetComponent<Tooltip> ();
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		if (item != null) {
			previous_parent_slot = this.transform.parent; 
			previous_slot_number = this.slot_number;
			offset = eventData.position - new Vector2 (this.transform.position.x, this.transform.position.y);
			this.transform.position = eventData.position;
			this.transform.parent = this.transform.parent.parent.parent;
			GetComponent<CanvasGroup> ().blocksRaycasts = false;
		}
			switch (inv.items [slot_number].Equipment_type) 
			{
			case Item.Gear_type.None:
				HeadBlock.raycastTarget = true;
				HandBlock.raycastTarget = true;
				TorsoBlock.raycastTarget = true;
				LegsBlock.raycastTarget = true;
				FeetBlock.raycastTarget = true;
				break;
			case Item.Gear_type.Head:
				HandBlock.raycastTarget = true;
				TorsoBlock.raycastTarget = true;
				LegsBlock.raycastTarget = true;
				FeetBlock.raycastTarget = true;
				break;
			case Item.Gear_type.Torso:
				HeadBlock.raycastTarget = true;
				HandBlock.raycastTarget = true;
				LegsBlock.raycastTarget = true;
				FeetBlock.raycastTarget = true;
				break;
			case Item.Gear_type.Gloves:
				HeadBlock.raycastTarget = true;
				TorsoBlock.raycastTarget = true;
				LegsBlock.raycastTarget = true;
				FeetBlock.raycastTarget = true;
				break;
			case Item.Gear_type.Legs:
				HeadBlock.raycastTarget = true;
				HandBlock.raycastTarget = true;
				TorsoBlock.raycastTarget = true;
				FeetBlock.raycastTarget = true;
				break;
			case Item.Gear_type.Boots:
				HeadBlock.raycastTarget = true;
				HandBlock.raycastTarget = true;
				TorsoBlock.raycastTarget = true;
				LegsBlock.raycastTarget = true;
				break;
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
		if (slot_number <= 19) {
			this.transform.SetParent (inv.slots [slot_number].transform);
			this.transform.position = inv.slots [slot_number].transform.position;
		} else {
			switch (this.slot_number)
			{
			case 20:
				this.transform.SetParent (GameObject.Find ("Slot1").transform);	
				this.transform.position = GameObject.Find ("Slot1").transform.position;
				break;
			case 21:
				this.transform.SetParent (GameObject.Find ("Slot2").transform);	
				this.transform.position = GameObject.Find ("Slot2").transform.position;
				break;
			case 22:
				this.transform.SetParent (GameObject.Find ("Slot3").transform);	
				this.transform.position = GameObject.Find ("Slot3").transform.position;
				break;
			case 23:
				this.transform.SetParent (GameObject.Find ("Slot4").transform);	
				this.transform.position = GameObject.Find ("Slot4").transform.position;
				break;
			case 24:
				this.transform.SetParent (GameObject.Find ("Slot5").transform);	
				this.transform.position = GameObject.Find ("Slot5").transform.position;
				break;
			}
		}
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		HeadBlock.raycastTarget = false;
		HandBlock.raycastTarget = false;
		TorsoBlock.raycastTarget = false;
		LegsBlock.raycastTarget = false;
		FeetBlock.raycastTarget = false;
	}

	private void Slot_pos_reset (int slot_number, int previous_slot_number, Transform previous_parent_slot)
	{
		inv.items [slot_number] = new Item ();
		inv.items [previous_slot_number] = this.item;
		this.slot_number = previous_slot_number;
		this.transform.SetParent (previous_parent_slot);
		this.transform.position = (previous_parent_slot.transform.position);
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
		if (eventData.clickCount == 2 && this.item.Effect_of_consumable != Item.Consumable_effect.None) 
		{
			inv.Update_subscript_and_remove_items (this.slot_number, ref inv.items, ref inv.slots, ref this.amount);
		}
	}
	/*
	void Update ()
	{
		if (Input.GetButtonDown ("Submit") == true){
				Debug.Log (slot_number);
				Debug.Log (previous_slot_number);
				Debug.Log (previous_parent_slot);
		}
	}
	*/
}
