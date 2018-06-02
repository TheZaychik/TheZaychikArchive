using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Inventory2 : MonoBehaviour {
	GameObject InventoryPanel;
	GameObject PlayerPanel;
	GameObject TraderPanel;
	GameObject ExchangeTraderPanel;
	GameObject ExchangePlayerPanel;
	//Trade block panels
	public Image PlayerBlock;
	public Image TraderBlock;
	public GameObject InventorySlot;
	public GameObject InventoryItem;
	public Text Gold_count;
	public Text Trader_gold;
	public int T_Item_cost;
	public Text Player_gold;
	public int P_Item_value;
	ItemDatabase database;
	public int SlotAmount;
	public Inventory inventory;

	public List<Item> items = new List<Item>();
	public List<GameObject> slots= new List<GameObject>();

	void Start () 
	{
		inventory = GameObject.Find ("Inventory").GetComponent<Inventory> ();
		database = GameObject.Find ("Inventory").GetComponent<ItemDatabase> ();
		SlotAmount = 20;
		InventoryPanel = GameObject.Find ("Trade Panel");
		PlayerPanel = InventoryPanel.transform.Find ("Slot Panel Player").gameObject;
		TraderPanel = InventoryPanel.transform.Find ("Slot Panel Trader").gameObject;
		ExchangeTraderPanel = InventoryPanel.transform.Find ("Slot Panel ExchangeTrader").gameObject;
		ExchangePlayerPanel = InventoryPanel.transform.Find ("Slot Panel ExchangePlayer").gameObject;
		//Finds the block panels
		PlayerBlock = GameObject.Find ("Player Block").GetComponent<Image> ();
		TraderBlock = GameObject.Find ("Trader Block").GetComponent<Image> ();
		Gold_count = GameObject.Find ("Gold_trading_system").GetComponent <Text> ();
		Trader_gold = GameObject.Find ("Trader_gold").GetComponent <Text> ();
		Player_gold = GameObject.Find ("Player_gold").GetComponent <Text> ();
		for (int i = 0; i < 20; i++) 
		{
			items.Add (new Item());
			slots.Add (Instantiate(InventorySlot));
			slots [i].GetComponent<Slot2>().id = i;
			slots [i].transform.SetParent (PlayerPanel.transform);
		}
		for (int i = 20; i < 25; i++) 
		{
			items.Add (new Item());
			slots.Add (Instantiate(InventorySlot));
			slots [i].GetComponent<Slot2>().id = i;
			slots [i].transform.SetParent (ExchangePlayerPanel.transform);
		}
		for (int i = 25; i < 45; i++) 
		{
			items.Add (new Item());
			slots.Add (Instantiate(InventorySlot));
			slots [i].GetComponent<Slot2>().id = i;
			slots [i].transform.SetParent (TraderPanel.transform);
		}
		for (int i = 45; i < 50; i++) 
		{
			items.Add (new Item());
			slots.Add (Instantiate(InventorySlot));
			slots [i].GetComponent<Slot2>().id = i;
			slots [i].transform.SetParent (ExchangeTraderPanel.transform);
		}
		Load_Trader_inventory ();
		Update_gold (1, 0);
		database.trading_canvas.SetActive (false);
	}

	public void Update_gold (int Switch, int Total_value)
	{
		switch (Switch)
		{
		case 1:
			Gold_count.text = "Gold: " + database.Gold_count.ToString ();
			break;
		case 2:
			T_Item_cost = Total_value;
			Trader_gold.text = "Item cost: " + Total_value.ToString ();
			break;
		case 3: 
			P_Item_value = Total_value;
			Player_gold.text = "Item value: " + Total_value.ToString ();
			break;
		}
	}

	public void Trade ()
	{
		int item_count = 0;
		int inventory_space = 0;
		for (int i = 0; i < 20; i++) 
		{
			if (items [i].ID == -1) 
			{
				inventory_space++;
			}
		}
		for (int i = 45; i < 49; i++) 
		{
			if (items [i].ID != -1) 
			{
				item_count++;
			}
		}
		if (P_Item_value + database.Gold_count >= T_Item_cost && inventory_space >= item_count) 
		{
			for (int i = 45; i < 50; i++)
			{
				if (items [i].ID != -1) 
				{
					AddItem (items [i].ID);
					items [i] = new Item ();
					Destroy (slots [i].transform.GetChild (0).transform.GetChild(0).GetComponent<Text>());
					Destroy (slots [i].transform.GetChild (0).GetComponent<LayoutElement>());
					Destroy (slots [i].transform.GetChild (0).GetComponent<Image>());
					Destroy (slots [i].transform.GetChild (0).gameObject);
				}
			}
			for (int i = 20; i < 25; i++) 
			{
				if (items [i].ID != -1) 
				{
					items [i] = new Item ();
					Destroy (slots [i].transform.GetChild (0).transform.GetChild (0).GetComponent<Text> ());
					Destroy (slots [i].transform.GetChild (0).GetComponent<LayoutElement> ());
					Destroy (slots [i].transform.GetChild (0).GetComponent<Image> ());
					Destroy (slots [i].transform.GetChild (0).gameObject);

				}
			}
			database.Gold_count = database.Gold_count - T_Item_cost;
			database.Gold_count = database.Gold_count + P_Item_value;
			Update_gold (1, 0);
			Update_gold (2, 0);
			Update_gold (3, 0);
		}
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
					ItemData2 data = slots [i].transform.GetChild (0).GetComponent<ItemData2> ();
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
					itemObj.GetComponent<ItemData2> ().item = Pending_Item;
					itemObj.GetComponent<ItemData2> ().amount = 1;
					itemObj.GetComponent<ItemData2> ().slot_number = i;
					itemObj.transform.SetParent (slots [i].transform);
					itemObj.GetComponent<Image> ().sprite = Pending_Item.Icon;
					itemObj.transform.position = (slots[i].transform.position);
					itemObj.name = Pending_Item.Title;
					break;
				}
			}
		}
	}

	public void Update_subscript (int slot_location, ref List<Item> item, ref List<GameObject> slots, ref int number)
	{
		ItemData2 data = slots [slot_location].transform.GetChild (0).GetComponent<ItemData2> ();

		if (data.amount > 2) {
			number--;
			data.transform.GetChild (0).GetComponent<Text> ().text = data.amount.ToString ();
		} else if (data.amount > 1) {
			number--;
			data.transform.GetChild (0).GetComponent<Text> ().text = "";
			}
			else 
			{
				item [slot_location] = new Item (); 
			Destroy (slots [slot_location].transform.GetChild (0).transform.GetChild(0));
			Destroy (slots [slot_location].transform.GetChild (0));
				Debug.Log (slot_location);
			}
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

	}
	public void Save_inventory ()
	{			
		ItemData2 data;
		for (int i = 0; i < 20; i ++)
		{
			if (items[i].ID != -1) {
				data = slots [i].transform.GetChild (0).GetComponent<ItemData2> ();
				PlayerPrefs.SetInt ("InventoryC " + i, data.amount);
			} else {
				PlayerPrefs.SetInt ("InventoryC " + i, 0);
			}
			PlayerPrefs.SetInt ("Inventory " + i, items[i].ID);
		}
		PlayerPrefs.SetInt ("Gold", database.Gold_count);
	}

	public void Load_inventory_T ()
	{
		for (int i = 0; i < 20; i++) 
		{
			if (PlayerPrefs.GetInt ("Inventory " + i) != -1 && PlayerPrefs.HasKey ("Inventory " + i) == true) {
				AddItemWithLocation (PlayerPrefs.GetInt ("Inventory " + i), i, PlayerPrefs.GetInt ("InventoryC " + i));
			}

			if (items [i].Stackable == true && PlayerPrefs.HasKey ("Inventory " + i) == true) 
			{
				ItemData data = slots [i].transform.GetChild (0).GetComponent<ItemData> ();
				data.transform.GetChild (0).GetComponent<Text> ().text = (PlayerPrefs.GetInt ("Inventory " + i) + 1).ToString ();
			}
		}
	}

	public void Load_Trader_inventory ()
	{
		for (int i = 25; i < 45; i++) 
		{
			if (PlayerPrefs.GetInt ("Blacksmith " + i) != -1 && PlayerPrefs.HasKey ("Blacksmith " + i) == true) {
				AddItemWithLocation (PlayerPrefs.GetInt ("Blacksmith " + i), i, PlayerPrefs.GetInt ("BlacksmithC " + i));
				//Debug.Log (1488);
			}

			if (items [i].Stackable == true && PlayerPrefs.HasKey ("Blacksmith " + i) == true) 
			{
				ItemData data = slots [i].transform.GetChild (0).GetComponent<ItemData> ();
				data.transform.GetChild (0).GetComponent<Text> ().text = (PlayerPrefs.GetInt ("Blacksmith " + i) + 1).ToString ();
			}
		}
	}

	private void AddItemWithLocation (int id, int location, int count)
	{
		Item Pending_Item = database.FetchItemByID (id);
		if (items [location].ID == -1) 
		{
			items [location] = Pending_Item;
			GameObject itemObj = Instantiate (InventoryItem);
			itemObj.GetComponent<ItemData2> ().item = Pending_Item;
			itemObj.GetComponent<ItemData2> ().amount = count;
			itemObj.GetComponent<ItemData2> ().slot_number = location;
			itemObj.transform.SetParent (slots [location].transform);
			itemObj.GetComponent<Image> ().sprite = Pending_Item.Icon;
			itemObj.transform.position = (slots[location].transform.position);
			itemObj.name = Pending_Item.Title;				
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

	public void Inventory_reset_T ()
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

	public void Activate_trade ()
	{ 
		//enusre that this function resets AND loads the trade window (player trade)
		inventory.Save_inventory_for_trade ();
		Inventory_reset_T ();
		Load_inventory_T ();
	}

	public void Deactivate_trade ()
	{
		database.trading_canvas.SetActive (false);
		Save_inventory (); 
		inventory.Inventory_reset (); //make sure that this does not tamper with the equipment section
		inventory.Load_inventory ();
	}
}
