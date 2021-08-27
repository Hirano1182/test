using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
	public string targetObjectName;
	public float speed = 3;
	public float knockbackpower = 8;
	
	float vx = 0;
	Rigidbody2D rbody;

	void Start()
    {
		rbody = GetComponent<Rigidbody2D>();
		rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
	}

	void Update()
	{
		if (Input.GetKey("right"))
		{ 
			vx = -speed;
			
		}
		if (Input.GetKey("left"))
		{ 
			vx = speed;
			
		}

	}
	void OnCollisionEnter2D(Collision2D collision)
	{ 
		if (collision.gameObject.name == targetObjectName)
		{
			StartCoroutine("Damage");
			
		}
	}

	IEnumerator Damage()
	{
		GetComponent<OnKeyPress_MoveGravityPlus>().enabled = false;
		rbody.AddForce(new Vector2(vx, knockbackpower), ForceMode2D.Impulse);
	
		yield return new WaitForSeconds(1.00f);
		GetComponent<OnKeyPress_MoveGravityPlus>().enabled = true;

	}
}