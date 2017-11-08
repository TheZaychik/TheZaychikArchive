using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using System.IO;

public class PlayerUI_Script : MonoBehaviour
{
	public Text HPText;
	public Text StaminaText;
	public GameObject ActiveQuest;
	public Text aq;

	public void Start()
	{
		aq = ActiveQuest.GetComponent<Text>();
		LoadData();
		SaveData();
	}

	public void HPChange(float HP)
	{
		HPText.text = "HP " + HP;
	}
	public void StaminaChange(float Stamina)
	{
		StaminaText.text = "Stamina " + Stamina;
	}
	public void Update()
	{
		if (Input.GetKey(KeyCode.Tab))
		{
			ActiveQuest.SetActive(true);

		}
		if (!Input.GetKey(KeyCode.Tab))
		{
			ActiveQuest.SetActive(false);
		}

	}
	public void LoadData()
	{
		using (StreamReader file = new StreamReader("BidloventurePlayerUI.txt"))
		{
			aq.text = Convert.ToString(file.ReadLine());

		}

	}
	public void SaveData()
	{
		using (StreamWriter file = new StreamWriter("BidloventurePlayerUI.txt"))
		{
			file.WriteLine(aq.text);
		}

	}
}
