using UnityEngine;
using System.Collections;

public class KillQuest : MonoBehaviour {
	ClassQuest cq;
	player_interaction pi;
	PlayerUI_Script ps;
	// Use this for initialization
	void Start () {
	    pi = GameObject.FindGameObjectWithTag("Player").GetComponent<player_interaction>();
		cq = GameObject.FindGameObjectWithTag("Player").GetComponent<ClassQuest>();
		ps = GameObject.FindGameObjectWithTag("UI_Player").GetComponent<PlayerUI_Script>();
	}
	
	// Update is called once per frame
	public void QuestCompl() {
			pi.QuestTaken = 2;
			ps.aq.text += "(выполнен)";
			ps.SaveData();
			pi.SaveData();

	}
}
