using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelTableUI : MonoBehaviour
{
	public Button btn1, btn2;
	public Button btn_next, btn_exit;
	public Sprite btn_c;
	public int selected_level;
	player_interaction pl;
	public GameObject lt;

	// Use this for initialization
	void Start()
	{
		pl = GameObject.FindGameObjectWithTag("Player").GetComponent<player_interaction>();
		btn1.onClick.AddListener(Btn1OnClick);
		btn2.onClick.AddListener(Btn2OnClick);
		btn_next.onClick.AddListener(NextOnClick);
		btn_exit.onClick.AddListener(ExitOnClick);
		if (pl.Levels_status[1] == true)
			btn1.image.sprite = btn_c;
		if (pl.Levels_status[2] == true)
			btn2.image.sprite = btn_c;
	}

	void Btn1OnClick()
	{
		selected_level = 2;
	}
	void Btn2OnClick()
	{
		selected_level = 3;
	}
	void NextOnClick()
	{
		pl.coords = GameObject.FindGameObjectWithTag("Player").transform.position;
		pl.SaveData();
		Application.LoadLevel(selected_level);
	}
	void ExitOnClick()
	{
		lt.SetActive(false);
	}
}
