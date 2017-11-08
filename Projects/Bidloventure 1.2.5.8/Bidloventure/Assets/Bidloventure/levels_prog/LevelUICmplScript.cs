using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelUICmplScript : MonoBehaviour {
	player_interaction pl;
	public Button Return;
	public Text Info;
	public bool Compl = false;
	public bool esc = false;
	int thislevel;

	void Start()
	{
		pl = GameObject.FindWithTag("Player").GetComponent<player_interaction>();
		thislevel = Application.loadedLevel;
	}

	void Update()
	{
		if (Compl && !esc)
		{
			pl.Levels_status[thislevel-1] = true;
			pl.SaveData();
			Return.onClick.AddListener(ComplAct);
			Info.text = "Уровень пройден!";

		}
		if (esc && !Compl)
		{
			Return.onClick.AddListener(EscAct);
			Info.text = " Хотите уйти с уровня?";
		}
	}

	void ComplAct()
	{
		pl.Levels = true;
		pl.SaveData();
		Application.LoadLevel(0);
	}
	void EscAct()
	{
		pl.Levels = true;
		pl.SaveData();
		Application.LoadLevel(0);
	}
}
