using UnityEngine;
using System.Collections;

public class LevelTable : MonoBehaviour
{

	// Use this for initialization
	public GameObject lt;
	// Use this for initialization
	void OnTriggerStay2D(Collider2D enter)
	{
		if (enter.CompareTag("Player"))
		{
			if (Input.GetKeyDown("e"))
			{
				lt.SetActive(true);
			}

		}

	}
}
