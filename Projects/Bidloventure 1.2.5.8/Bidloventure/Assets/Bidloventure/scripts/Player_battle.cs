using UnityEngine;
using System.Collections;

public class Player_battle : MonoBehaviour
{
	public float Stamina;
	PlayerUI_Script PUS;
	Rigidbody2D rb;
	float xP;
	float yP;
	ItemDatabase database;
	Inventory inv;
	// Use this for initialization
	void Start()
	{
		database = GameObject.Find ("Inventory").GetComponent <ItemDatabase> ();
		inv = GameObject.Find ("Inventory").GetComponent<Inventory> ();
		Stamina = 100f;
		PUS = GameObject.FindGameObjectWithTag("UI_Player").GetComponent<PlayerUI_Script>();
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		PUS.HPChange(database.Player_health);
        PUS.StaminaChange(Stamina);  // ну шоб не забыл
        Debug.Log("МАААКС! Я отключил смерть в Player_battle.cs, из-за того что не нашел где записываются данные о хп, а так все пофиксил");
        
	}

	public void Hit(float damage, float powerX, float powerY)
	{
		xP = rb.mass * rb.gravityScale * powerX;
		yP = rb.mass * 9.8f * powerY;
		rb.AddForce(new Vector2(xP, yP));
		if ((damage - database.Armour > 0))
			database.Player_health -= (damage) - database.Armour;
		else
			database.Player_health -= 1; 
		
		if (database.canvas.activeSelf == true)
			inv.Gold_update (database.Player_health, inv.HP_full, "HP", 1);
	//	if (database.Player_health <= 0)  
	//		this.gameObject.SetActive(false);
	}

}
