using UnityEngine;
using System.Collections;

public class Forge_Enter : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
    player_interaction pl_i;
	Transform pl;
	Inventory inventory;
    // Use this for initialization
    void Start()
    {
		inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
		pl_i = player.GetComponent<player_interaction>();
    }
	// Update is called once per frame

	void OnTriggerStay2D(Collider2D enter)
	{
		if (enter.CompareTag("Player"))
		{
			if (Input.GetKeyDown("e"))
			{
				inventory.Exit_save();
				pl_i.coords = player.transform.position;
				pl_i.SaveData();
				Application.LoadLevel(1);
			}
		}

    }
}
