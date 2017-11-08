using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelExit : MonoBehaviour
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
		if (enter.CompareTag("Player")) {
			Debug.Log("Exit");
			lt.SetActive(true);
			lucs.Compl = true;
		}
	}
}
