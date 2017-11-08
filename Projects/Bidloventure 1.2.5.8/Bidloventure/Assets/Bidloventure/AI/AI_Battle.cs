using UnityEngine;
using System.Collections;

public class AI_Battle : MonoBehaviour
{
	public float HP = 100;
	float coolD = 0;
	float coolDA = 0;
	Rigidbody2D pl;
	Player_battle pb;
	AIControl aic;
	ItemDatabase database; 

	// --
	KillQuest kq;
	ClassQuest cq;
	player_interaction pi;
	PlayerUI_Script ps;
	//--

	// Use this for initialization
	void Start()
	{
		database = GameObject.Find ("Inventory").GetComponent <ItemDatabase> ();
		pi = GameObject.FindGameObjectWithTag("Player").GetComponent<player_interaction>();
		cq = GameObject.FindGameObjectWithTag("Player").GetComponent<ClassQuest>();
		ps = GameObject.FindGameObjectWithTag("UI_Player").GetComponent<PlayerUI_Script>();
		pb = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_battle>();
		kq = GetComponent<KillQuest>();
		aic = GetComponent<AIControl>();
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		coolD -= 1; 
		coolDA -= 1;
		if (HP <= 0)
		{
			if (pi.QuestTaken == 1)
			{
				kq.QuestCompl();
			}
			database.Gold_count += 5;
			this.gameObject.SetActive(false);
		}

	}
	void OnCollisionStay2D(Collision2D touch)
	{

		if ((touch.collider.CompareTag("Player") && Input.GetKey("mouse 0")) && coolD < 0)
		{
			HP -= 25;
		//	Debug.Log(HP);
			coolD = 5;
		}
		if (touch.collider.CompareTag("Player") && coolDA < 0)
		{
			if (GameObject.FindGameObjectWithTag("Player").transform.position.x < this.gameObject.transform.position.x)
				pb.Hit(10f, -2000f, 50f);
			else 
				pb.Hit(10f, 2000f, 50f);
			aic.m_Jump = false;
			coolDA = 50f;
		}

	}
}
