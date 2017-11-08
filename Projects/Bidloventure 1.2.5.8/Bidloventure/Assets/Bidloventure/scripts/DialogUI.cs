using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogUI : MonoBehaviour
{
	player_interaction pl;
	ClassQuest co;
	public Button ans1, ans2, trd, ext;
	public GameObject prsn, prsn_ans, dialog;
	public Text prsnt, prsn_anst, player_ans1, player_ans2;
	public bool Nr_Smth;
	ItemDatabase database;
	Inventory2 inventory2;
	int id;
	int currentQuest;
	bool QuestDialog = false;
	// Use this for initialization
	void Start()
	{

		database = GameObject.Find("Inventory").GetComponent<ItemDatabase>();
		inventory2 = GameObject.Find("Inventory_trading").GetComponent<Inventory2>();
		pl = GameObject.FindGameObjectWithTag("Player").GetComponent<player_interaction>();
		co = GameObject.FindGameObjectWithTag("Player").GetComponent<ClassQuest>();
		prsnt = prsn.GetComponent<Text>();
		prsn_anst = prsn_ans.GetComponent<Text>();
		ans1.onClick.AddListener(ans1OnClick);
		ans2.onClick.AddListener(ans2OnClick);
		trd.onClick.AddListener(trdOnClick);
		ext.onClick.AddListener(extOnClick);
		if (Nr_Smth == true)
		{
			prsnt.text = "Кузнец";
			id = 0;
		}

	}
	// Update is called once per frame
	void Update()
	{

	}
	void ans1OnClick()
	{
		if (QuestDialog)
		{
			co.AcceptQuest();
			QuestDialog = false;
            extOnClick();
		}
		else if (Nr_Smth == true)
		{
			prsn_anst.text = "Неплохо! Нередко можно встреть в наших краях искателей приключений.";
		}
	}
	void ans2OnClick()
	{
		if (!QuestDialog)
		{
			if (pl.QuestTaken == 0)
			{
				co.GetQuest(id);
				QuestDialog = true;
			}
			if (pl.QuestTaken == 1)
			{
				string a = "";
				prsn_anst.text = co.GetText(a);
			}
			if (pl.QuestTaken == 2)
			{
				string a = "";
				prsn_anst.text = co.GetText(a);
				co.QuestComlete();
			}
		}
		else if(QuestDialog)
		{
			QuestDialog = false;
            extOnClick();
		}    
	}
	void trdOnClick()
	{
		if (!QuestDialog)
		{
			if (database.canvas.activeSelf == true)
				database.canvas.SetActive(false);
			database.trading_canvas.SetActive(true);
			inventory2.Activate_trade();
			dialog.SetActive(false);
		}
	}
	void extOnClick()
	{
        player_ans1.text = "1) Привет! Как дела?";
        player_ans2.text = "2) Я по поводу задания";
        prsn_anst.text = "-";
        dialog.SetActive(false);
	}

}
