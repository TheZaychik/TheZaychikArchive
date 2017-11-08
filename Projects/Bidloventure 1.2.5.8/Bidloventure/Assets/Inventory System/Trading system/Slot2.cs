using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Slot2 : MonoBehaviour, IDropHandler {

	private Inventory2 inv;
	public int id;

	public void OnDrop(PointerEventData eventData)
	{
		ItemData2 droppedItem = eventData.pointerDrag.GetComponent<ItemData2>();
		if (inv.items [id].ID == -1) {
			inv.items [droppedItem.slot_number] = new Item ();
			inv.items [id] = droppedItem.item;
			droppedItem.slot_number = id;
		} else if (droppedItem.slot_number != id)
		{
			Transform item = this.transform.GetChild (0);
			item.GetComponent<ItemData2> ().slot_number = droppedItem.slot_number;
			item.transform.SetParent (inv.slots [droppedItem.slot_number].transform);
			item.transform.position = inv.slots [droppedItem.slot_number].transform.position;
			
			droppedItem.slot_number = id;
			droppedItem.transform.SetParent (this.transform);
			droppedItem.transform.position = this.transform.position;
			
			inv.items [droppedItem.slot_number] = item.GetComponent<ItemData2> ().item;
			inv.items [id] = droppedItem.item;
		}
	}

	void Start () {
		inv = GameObject.Find ("Inventory_trading").GetComponent<Inventory2> ();
	}
}
