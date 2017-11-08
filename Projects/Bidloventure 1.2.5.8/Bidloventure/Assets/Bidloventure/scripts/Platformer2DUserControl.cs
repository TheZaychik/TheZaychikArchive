using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Platformer2DUserControl : MonoBehaviour
{
	PlatformerCharacter2D m_Character;
	Player_battle pb;
	Rigidbody2D player;
	private bool m_Jump;
	private bool Run;
	private bool StamFull;
	private byte CoolDStam = 1;
	private float h;
	void Start()
	{
		StamFull = true;
		m_Character = GetComponent<PlatformerCharacter2D>();
		pb = GetComponent<Player_battle>();
		player = GetComponent<Rigidbody2D>();
	}
	private void Update()
	{
		if (!m_Jump)
			m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
	}

	private void FixedUpdate()
	{
		CoolDStamFunc();
		bool crouch = Input.GetKey(KeyCode.LeftControl);
		h = CrossPlatformInputManager.GetAxis("Horizontal");
		if (StamFull)
			Run = Input.GetKey(KeyCode.LeftShift);
		m_Character.Move(h, Run, crouch, m_Jump);
		m_Jump = false;
	}
	private void StaminaFunc()
	{
		if ((Run && h!=0f)&& pb.Stamina > 0)   // cтаминаа | скорость перса ход 4,5 бег 8,7
			pb.Stamina -= 1f;
		if (pb.Stamina <= 0f)
		{
			StamFull = false;
			Run = false;
		}
		if ((!Run || !StamFull) && pb.Stamina < 100f )
		{
			pb.Stamina += 3f;
			if (pb.Stamina > 100f)
				pb.Stamina = 100f;
			if(pb.Stamina > 30f)
			 	StamFull = true;
		}
	}

	private void CoolDStamFunc()
	{
		CoolDStam += 1;
		if (CoolDStam > 6)
		{
			StaminaFunc();
			CoolDStam = 1;
		}
	}
}


