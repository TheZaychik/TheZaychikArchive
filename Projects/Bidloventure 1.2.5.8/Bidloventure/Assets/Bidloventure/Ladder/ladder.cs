using UnityEngine;
using System.Collections;

public class ladder : MonoBehaviour
{
	public GameObject player;
	Rigidbody2D rbp;
	bool up = false;
	bool down = false;
	// Use this for initialization
	private void Start()
	{
		player = GameObject.FindWithTag("Player");
		rbp = player.GetComponent<Rigidbody2D>();
	}
	private void Update() // поскольку функции холда кнопки так же нету, то пилим аддфорс в апдейте, с щипоткой була
	{
		if (up)
			rbp.AddForce(new Vector2(0, 40f));
		if(down)
			rbp.AddForce(new Vector2(0, -40f));
	}
	private void OnTriggerStay2D(Collider2D enter) // Знакомтесть! Система костылей,ибо в юнити нет оператора GetKeyHold :(
	{
		if (enter.CompareTag("Player"))
		{
			if (Input.GetKeyDown("w"))
			{
				up = true;
				down = false;
			}
			if (Input.GetKeyUp("w"))
				up = false;
			if (Input.GetKeyDown("s"))
			{
				up = false;
				down = true;
			}
			if (Input.GetKeyUp("s"))
				down = false;
		}
	}
	private void OnTriggerExit2D(Collider2D enter) 
	{
		if (enter.CompareTag("Player"))
		{
			up = false;
			down = false;
		}
	}
}