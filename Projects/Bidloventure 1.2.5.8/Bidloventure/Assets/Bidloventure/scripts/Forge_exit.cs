using UnityEngine;
using System.Collections;

public class Forge_exit : MonoBehaviour {

    player_interaction pl_i;
	Inventory inventory; 
    // Use this for initialization
    void Start()
    {
		inventory = GameObject.Find("Inventory").GetComponent<Inventory>();
		pl_i = GameObject.FindGameObjectWithTag("Player").GetComponent<player_interaction>();
    }
	void OnTriggerStay2D(Collider2D enter)
	{
		if (Input.GetKeyDown("e"))
		{
			pl_i.Levels = true;
			pl_i.SaveData();
			Application.LoadLevel(0);
		}
	}
}
