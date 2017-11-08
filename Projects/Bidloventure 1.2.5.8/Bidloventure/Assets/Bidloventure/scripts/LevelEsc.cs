using UnityEngine;
using System.Collections;

public class LevelEsc : MonoBehaviour
{
	public GameObject lt;
	LevelUICmplScript lucs;
	// Use this for initialization
	void Start()
	{
		lucs = lt.GetComponent<LevelUICmplScript>();
	}

	void OnTriggerEnter2D(Collider2D enter)
	{
		if (enter.CompareTag("Player"))
		{
			lt.SetActive(true);
			lucs.esc = true;
		}
	}
	void OnTriggerExit2D(Collider2D enter)
	{
		if (enter.CompareTag("Player"))
		{
			lucs.esc = false;
			lt.SetActive(false);
		}
	}
}

