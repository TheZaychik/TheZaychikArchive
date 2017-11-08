using UnityEngine;
using System.Collections;
using LitJson;
using System.Collections.Generic;
using System.IO;
using System;

public class ItemDatabase : MonoBehaviour {
	private List<Item> database = new List<Item>();
	private JsonData itemData;
	public int Gold_count;
	public int Armour;
	public GameObject canvas;
	public GameObject trading_canvas;
	public float Player_health;
	void Start()
	{
		canvas = GameObject.Find ("Canvas"); 
		trading_canvas = GameObject.Find ("Canvas (trading)"); 
		itemData = JsonMapper.ToObject (File.ReadAllText (Application.dataPath + "/Inventory system/StreamingAssets/Items.json"));
		ConstructItemDatabase ();
		Blacksmith_inventory ();
		//Gold_count = 100;
		//PlayerPrefs.SetInt ("Gold", Gold_count);
		//EXECUTE IF THE SAVE IS CORRUPTED
		//PlayerPrefs.DeleteAll();
	}
	public Item FetchItemByID(int id)
	{
		for (int i = 0; i < database.Count; i++) 
		{
			if (database [i].ID == id) {
				return database[i];
			}
		}
		return null;
	}

	void Update ()
	{
		
	}

	public void Blacksmith_inventory ()
	{
		PlayerPrefs.SetInt ("Blacksmith 25", 0);
	}

	void ConstructItemDatabase ()
	{
		for (int i = 0; i < itemData.Count; i++) {
			database.Add (new Item ((int)itemData [i]["id"], itemData [i]["title"].ToString(), (int)itemData [i]["value"],
				(int)itemData [i]["strength"], (int)itemData [i]["armour"], (int)itemData [i]["damage"], itemData [i]["description"].ToString(),
				(bool)itemData [i]["stackable"], itemData [i]["slug"].ToString(), (bool)itemData[i]["equipable"],
				(Item.Gear_type)Enum.Parse (typeof(Item.Gear_type), itemData[i]["Gear_type"].ToString()), 
				(Item.Consumable_effect)Enum.Parse (typeof(Item.Consumable_effect), itemData[i]["Consumable_effect"].ToString()), 
				(int)itemData[i]["Consumable_scale"]));
		}
	}

}

public class Item
{
	public int 		ID { get; private set; }
	public string 	Title { get; private set; }
	public int 		Value { get; private set; }
	public int 		Strenght { get; private set; }
	public int 		Armour { get; private set; }
	public int 		Damage { get; private set; }
	public string 	Description { get; private set; }
	public bool 	Stackable { get; private set; }
	public string 	Slug { get; private set; }
	public Sprite 	Icon { get; set; }
	public bool 	Equipable { get; set; }
	public enum 	Gear_type	{Head, Gloves, Torso, Legs, Boots, None};
	public 			Gear_type Equipment_type;
	public enum 	Consumable_effect	{None, Health};
	public			Consumable_effect Effect_of_consumable;
	public int 		Consumable_scale { get; set; }

	public Item(int id, string title, int value, int strength, int armour, int damage, string desc, bool stackable, string slug, bool equipable, Gear_type Type_of_gear, Consumable_effect effect_of_consumable, int consumable_scale)
	{
		this.ID = id;
		this.Title = title;
		this.Value = value;
		this.Strenght = strength;
		this.Armour = armour;
		this.Damage = damage;
		this.Description = desc;
		this.Stackable = stackable;
		this.Slug = slug;
		this.Icon = Resources.Load<Sprite> ("Sprites/Items/" + slug);
		this.Equipable = equipable;
		this.Equipment_type = Type_of_gear;
		this.Effect_of_consumable = effect_of_consumable;
		this.Consumable_scale = consumable_scale;
	}
	public Item ()
	{
		this.ID = -1;
		this.Icon = null;
	}
}