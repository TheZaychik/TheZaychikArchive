using System;
using UnityEngine;


	public class AICharControl : MonoBehaviour
	{
		[SerializeField]
		private float max_walk = 5f;

	
		private Animator m_Anim;            // Reference to the player's animator component.
		private Rigidbody2D m_Rigidbody2D;
		private bool m_FacingRight = true;  // For determining which way the player is currently facing.

		private void Awake()
		{
	
			m_Anim = GetComponent<Animator>();
			m_Rigidbody2D = GetComponent<Rigidbody2D>();
		}


		private void FixedUpdate()
		{

			m_Anim.SetFloat("vSpeed", m_Rigidbody2D.velocity.y);
		}


		public void Move(float move,bool jump)
		{
				// The Speed animator parameter is set to the absolute value of the horizontal input.
				m_Anim.SetFloat("Speed", Mathf.Abs(move));
				m_Rigidbody2D.velocity = new Vector2(move * max_walk, m_Rigidbody2D.velocity.y);
				
			    if (jump)
			    {
				    m_Rigidbody2D.AddForce(new Vector2(0f, 40f));
			    } 
				if (move > 0 && !m_FacingRight)
				{
					Flip();
				}
				else if (move < 0 && m_FacingRight)
				{
					Flip();
				}
		
		}


		private void Flip()
		{
			// Switch the way the player is labelled as facing.
			m_FacingRight = !m_FacingRight;
			// Multiply the player's x local scale by -1.
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
		}
	}

