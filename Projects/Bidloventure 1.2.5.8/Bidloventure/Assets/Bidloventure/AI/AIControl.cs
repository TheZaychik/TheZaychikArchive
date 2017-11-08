using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class AIControl : MonoBehaviour
{

	private AICharControl m_Character;
	public bool m_Jump;
	public bool Pl_in;
	public bool Pl_battle;
	private Transform pl;
	private Transform ai;
	public float h;
	private Animator ai_ani;
	private void Start()
	{
		Pl_in = false;
		Pl_battle = false;
		m_Character = GetComponent<AICharControl>();
		pl = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		ai = GetComponent<Transform>();
		ai_ani = GetComponent<Animator>();

	}
	void OnTriggerStay2D(Collider2D pl_check)
	{
		if (pl_check.CompareTag("Player"))
			Pl_in = true;
	}


	private void FixedUpdate()
	{
		if (Pl_in)
		{
			if (pl.position.x > ai.position.x)
				h = 1;
			if (pl.position.x < ai.position.x)
				h = -1;
			if (pl.position.y > (ai.position.y + 1))
				m_Jump = true;
			m_Character.Move(h, m_Jump);
			m_Jump = false;
			Pl_in = false;

		}
		else
		{
			ai_ani.SetFloat("Speed", 0f);
		}

	}
}


