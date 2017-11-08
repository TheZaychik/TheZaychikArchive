using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler {

	private Inventory inv;
	public int id;
	private bool remove_equip;

	public void OnDrop(PointerEventData eventData)
	{
		ItemData droppedItem = eventData.pointerDrag.GetComponent<ItemData>();
		if (inv.items [id].ID == -1) {
			if (droppedItem.slot_number >= 20) 
			{
				inv.database.Armour = inv.database.Armour - inv.items [droppedItem.slot_number].Armour;
			}
			inv.items [droppedItem.slot_number] = new Item ();
			inv.items [id] = droppedItem.item;
			droppedItem.slot_number = id;
			if (droppedItem.slot_number >= 20) 
			{
				inv.database.Armour = inv.database.Armour + inv.items [droppedItem.slot_number].Armour;
			}
			inv.Gold_update (inv.database.Armour, 0, "Armour", 0);
		}

		if (droppedItem.slot_number != id && id <= 19)
		{
			Transform item = this.transform.GetChild (0);
			item.GetComponent<ItemData> ().slot_number = droppedItem.slot_number;
			item.transform.SetParent (inv.slots [droppedItem.slot_number].transform);
			item.transform.position = inv.slots [droppedItem.slot_number].transform.position;

			droppedItem.slot_number = id;
			droppedItem.transform.SetParent (this.transform);
			droppedItem.transform.position = this.transform.position;

			inv.items [droppedItem.slot_number] = item.GetComponent<ItemData> ().item;
			inv.items [id] = droppedItem.item;
		}
	}

	void Start () {
		inv = GameObject.Find ("Inventory").GetComponent<Inventory> ();
	}
}
