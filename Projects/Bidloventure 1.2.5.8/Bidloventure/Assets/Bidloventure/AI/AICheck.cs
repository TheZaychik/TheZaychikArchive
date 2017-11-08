using UnityEngine;
using System.Collections;

	public class AICheck : MonoBehaviour
	{
		AIControl aic;
		// Use this for initialization
		void Start()
		{
			aic = GetComponentInChildren<AIControl>();

		}
		void OnTriggerStay2D(Collider2D pl_check)
		{
			if (pl_check.CompareTag("Player"))
				aic.Pl_in = true;

		}

	}
