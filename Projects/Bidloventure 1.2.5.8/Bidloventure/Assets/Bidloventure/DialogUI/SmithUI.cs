using UnityEngine;
using System.Collections;

public class SmithUI : MonoBehaviour
{
	
	player_interaction pl_i;
	DialogUI d_ui;
	public GameObject smith_d;
	// Use this for initialization
	void Start()
	{
		pl_i = GameObject.FindGameObjectWithTag("Player").GetComponent<player_interaction>();
		d_ui = smith_d.GetComponent<DialogUI>();
	}
	void OnTriggerStay2D(Collider2D enter)
	{
		if (Input.GetKeyDown("e"))
		{
			smith_d.SetActive(true);
			d_ui.Nr_Smth = true;
		}
	}
}
