using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {
	GameObject InventoryPanel;
	GameObject SlotPanel;
	public GameObject InventorySlot;
	public GameObject InventoryItem;
	public ItemDatabase database;
	public int SlotAmount;
	private Tooltip tooltip;
	public int HP_full;
	public List<Item> items = new List<Item>();
	public List<GameObject> slots= new List<GameObject>();

	void Start () 
	{
		database = GameObject.Find ("Inventory").GetComponent <ItemDatabase> ();
		HP_full = 100;
		tooltip = GetComponent<Tooltip> ();
		database = GetComponent<ItemDatabase> ();
		SlotAmount = 20;
		InventoryPanel = GameObject.Find ("Inventory Panel");
		SlotPanel = InventoryPanel.transform.Find ("Slot Panel").gameObject;
		database.Armour = 0;

		for (int i = 0; i < SlotAmount; i++) 
		{
			items.Add (new Item());
			slots.Add (Instantiate(InventorySlot));
			slots [i].GetComponent<Slot>().id = i;
			slots [i].transform.SetParent (SlotPanel.transform);
		}

		for (int i = 0; i < 5; i++) {
			items.Add (new Item ());
		}
		Load_inventory ();
		//database.Gold_count = 100; 
		//database.Player_health = 100; 
		Gold_update (database.Gold_count, 0, "Gold", 0);
		Gold_update (database.Player_health, HP_full, "HP", 1);
		Gold_update (database.Armour, 0, "Armour", 0);
		database.canvas.SetActive (false);
	}
	public void AddItem (int id) 
	{
		Item Pending_Item = database.FetchItemByID (id);

		if (Pending_Item.Stackable == true && Inventory_check(Pending_Item) == true) 
		{
			for (int i = 0; i < items.Count; i++) 
			{
				if (items [i].ID == id) 
				{
					ItemData data = slots [i].transform.GetChild (0).GetComponent<ItemData> ();
					data.amount++;
					data.transform.GetChild (0).GetComponent<Text> ().text = data.amount.ToString();
					break;
				}
			}
		}
		if (Pending_Item.Stackable == false || Inventory_check(Pending_Item) == false) {
			for (int i = 0; i < items.Count; i++)
			{
				if (items [i].ID == -1) 
				{
					items [i] = Pending_Item;
					GameObject itemObj = Instantiate (InventoryItem);
					itemObj.GetComponent<ItemData> ().item = Pending_Item;
					itemObj.GetComponent<ItemData> ().amount = 1;
					itemObj.GetComponent<ItemData> ().slot_number = i;
					itemObj.transform.SetParent (slots [i].transform);
					itemObj.GetComponent<Image> ().sprite = Pending_Item.Icon;
					itemObj.transform.position = (slots[i].transform.position);
					itemObj.name = Pending_Item.Title;
					break;
				}
			}
	}
	}

	private void AddItemWithLocation (int id, int location, int count)
	{
		Item Pending_Item = database.FetchItemByID (id);
		if (items [location].ID == -1 && location <= 19) 
			{
			items [location] = Pending_Item;
			GameObject itemObj = Instantiate (InventoryItem);
			itemObj.GetComponent<ItemData> ().item = Pending_Item;
			itemObj.GetComponent<ItemData> ().amount = count;
			itemObj.GetComponent<ItemData> ().slot_number = location;
			itemObj.transform.SetParent (slots [location].transform);
			itemObj.GetComponent<Image> ().sprite = Pending_Item.Icon;
			itemObj.transform.position = (slots[location].transform.position);
			itemObj.name = Pending_Item.Title;				
		} else if (items [location].ID == -1 && location >= 20) 
		{
			items [location] = Pending_Item;
			GameObject itemObj = Instantiate (InventoryItem);
			itemObj.GetComponent<ItemData> ().item = Pending_Item;
			itemObj.GetComponent<ItemData> ().amount = count; 
			itemObj.GetComponent<ItemData> ().slot_number = location;
			itemObj.transform.SetParent (GameObject.Find ("Slot" + (location - 19).ToString ()).transform);
			itemObj.GetComponent<Image> ().sprite = Pending_Item.Icon;
			itemObj.transform.position = (GameObject.Find ("Slot" + (location - 19).ToString ()).transform.position);
			itemObj.name = Pending_Item.Title;
		}
	}

	public void Use_Consumable (ref List<Item> items, int slot_locaion)
	{
		if (items[slot_locaion].Effect_of_consumable == Item.Consumable_effect.Health)
		{
			if ((items [slot_locaion].Consumable_scale + database.Player_health) <= HP_full) {
				database.Player_health = items [slot_locaion].Consumable_scale + database.Player_health;
				Gold_update (database.Player_health, HP_full, "HP", 1);
			} else {
				database.Player_health = 100;
				Gold_update (database.Player_health, HP_full, "HP", 1);
			}
		}
	}

	//Optional : split this funcion into two - update subscript AND remove items, for the sake of optimisation 
	public void Update_subscript_and_remove_items (int slot_location, ref List<Item> item, ref List<GameObject> slots, ref int number)
	{
		ItemData data = slots [slot_location].transform.GetChild (0).GetComponent<ItemData> ();
		if (data.amount > 2) {
			number--;
			data.transform.GetChild (0).GetComponent<Text> ().text = data.amount.ToString ();
		} else if (data.amount > 1) {
			number--;
			data.transform.GetChild (0).GetComponent<Text> ().text = "";
		}
		else 
		{
			Use_Consumable (ref item, slot_location);
			item [slot_location] = new Item ();
			Destroy (slots [slot_location].transform.GetChild (0).transform.GetChild(0).GetComponent<Text>());
			Destroy (slots [slot_location].transform.GetChild (0).GetComponent<LayoutElement>());
			Destroy (slots [slot_location].transform.GetChild (0).GetComponent<Image>());
			Destroy (slots [slot_location].transform.GetChild (0).gameObject);
			tooltip.Deactivate ();
		}
		Use_Consumable (ref item, slot_location);
	}



	bool Inventory_check (Item item)
	{
		for (int i = 0; i < items.Count; i++)
		{
			if (items [i].ID == item.ID)
				return true;
		}
		return false;
	}



	void Update ()
	{
		try {
			if (Input.GetKeyDown ("i") && database.trading_canvas.activeSelf == false ) 
			{
				database.canvas.SetActive (!database.canvas.activeSelf);
				if (database.canvas.activeSelf == true)
				{
					Gold_update (database.Gold_count, 0, "Gold", 0);
					Gold_update (database.Player_health, HP_full, "HP", 1);
				}
			}
		} catch {
			database.canvas.SetActive (!database.canvas.activeSelf);
		}
		/*
		 if (Input.GetButtonDown ("Submit") == true)
		{
			Debug.Log (database.Armour);
			}
		/*
		if (Input.GetButtonDown ("Submit") == true)
		{
			for (int i = 0; i < items.Count; i++) {
				Debug.Log (items[i].Title);
			}
		}
		/*
		if (Input.GetButtonDown ("Save Inventory"))
			Save_inventory ();
		if (Input.GetButtonDown ("Load Inventory"))
			Load_inventory ();
			*/
	}
	public void Gold_update (int Value_1, int Value_2, string name_of_textbox, int switcher)
	{
		switch (switcher)
		{
		case 0:
			Text updateable_textbox = GameObject.Find (name_of_textbox).GetComponent<Text> ();
			updateable_textbox.text = name_of_textbox + ": " + Value_1;
			break;
		case 1:
			updateable_textbox = GameObject.Find (name_of_textbox).GetComponent<Text> ();
			updateable_textbox.text = name_of_textbox + ": " + Value_1 + "/" + Value_2;
			break;
		}
	}
	//Overload method with float instead of int
	public void Gold_update (float Value_1, int Value_2, string name_of_textbox, int switcher)
	{
		switch (switcher)
		{
		case 0:
			Text updateable_textbox = GameObject.Find (name_of_textbox).GetComponent<Text> ();
			updateable_textbox.text = name_of_textbox + ": " + Value_1;
			break;
		case 1:
			updateable_textbox = GameObject.Find (name_of_textbox).GetComponent<Text> ();
			updateable_textbox.text = name_of_textbox + ": " + Value_1 + "/" + Value_2;
			break;
		}
	}

	public void Save_inventory ()
	{			
		ItemData data;
		for (int i = 0; i < items.Count; i ++)
		{
			if (i <= 19 && items[i].ID != -1) {
				 data = slots [i].transform.GetChild (0).GetComponent<ItemData> ();
				 PlayerPrefs.SetInt ("InventoryC " + i, data.amount);
			} else if (i >= 20 && items[i].ID != -1) {
				data = (GameObject.Find ("Slot" + (i - 19)).transform.GetChild (0).GetComponent<ItemData> ());
				PlayerPrefs.SetInt ("InventoryC " + i, data.amount);
			} else {
				PlayerPrefs.SetInt ("InventoryC " + i, 0);
			}
			PlayerPrefs.SetInt ("Inventory " + i, items[i].ID);
		}
		PlayerPrefs.SetInt ("Gold", database.Gold_count);
		PlayerPrefs.SetInt ("Armour", database.Armour);
		PlayerPrefs.SetFloat ("PlayerHealth", database.Player_health);
	}

	public void Save_inventory_for_trade ()
	{
		ItemData data;
		for (int i = 0; i < items.Count; i ++)
		{
			if (i <= 19 && items[i].ID != -1) {
				data = slots [i].transform.GetChild (0).GetComponent<ItemData> ();
				PlayerPrefs.SetInt ("InventoryC " + i, data.amount);
			} else {
				PlayerPrefs.SetInt ("InventoryC " + i, 0);
			}
			PlayerPrefs.SetInt ("Inventory " + i, items[i].ID);
		}
	}

	public void Load_inventory ()
	{
		for (int i = 0; i < items.Count; i++) 
		{
			if (PlayerPrefs.GetInt ("Inventory " + i) != -1 && PlayerPrefs.HasKey ("Inventory " + i) == true) {
				AddItemWithLocation (PlayerPrefs.GetInt ("Inventory " + i), i, PlayerPrefs.GetInt ("InventoryC " + i));
			}
			if (items [i].Stackable == true && PlayerPrefs.HasKey ("Inventory " + i) == true) 
			{
				ItemData data = slots [i].transform.GetChild (0).GetComponent<ItemData> ();
				data.transform.GetChild (0).GetComponent<Text> ().text = (PlayerPrefs.GetInt ("Inventory " + i) + 1).ToString ();
			}
			database.Gold_count = PlayerPrefs.GetInt ("Gold");
			database.Armour = PlayerPrefs.GetInt ("Armour"); 
			database.Player_health = PlayerPrefs.GetFloat ("PlayerHealth");
		}
	}

	public void Inventory_reset ()
	{
		for (int i = 0; i < 20; i++) {
			try {
				if (slots [i].transform.GetChild (0) != null) {
							Remove_Items (i);
					}
				} catch {
			}
		}
	}
	public void Remove_Items (int i)
	{
		items [i] = new Item ();
		Destroy (slots [i].transform.GetChild (0).transform.GetChild(0).GetComponent<Text>());
		Destroy (slots [i].transform.GetChild (0).GetComponent<LayoutElement>());
		Destroy (slots [i].transform.GetChild (0).GetComponent<Image>());
		Destroy (slots [i].transform.GetChild (0).gameObject);
	}

	public void Exit_save ()
	{
		if (database.canvas.activeSelf == false) 
		{
			database.canvas.SetActive (true);
		}
		Save_inventory ();
	}
}
