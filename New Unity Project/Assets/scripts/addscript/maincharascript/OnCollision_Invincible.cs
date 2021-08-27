using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_Invincible : MonoBehaviour
{
	public string target;
	private Renderer render;
	


	void start()
    {
		render = GetComponent<SpriteRenderer>();
		
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		//Enemy�ƂԂ��������ɃR���[�`�������s
		if (col.gameObject.name == target)
		{
			if (col.gameObject.tag == "Enemy")
			{
				StartCoroutine("Damage");
			}
		}
	}

	IEnumerator Damage()
	{
		//���C���[��PlayerDamage�ɕύX
		this.gameObject.layer = LayerMask.NameToLayer("playerdamage");
		//while����10�񃋁[�v
		int count = 15;
		while (count > 0)
		{
			//�����ɂ���
			GetComponent<Renderer>().material.color = Color.red;

			//0.05�b�҂�
			yield return new WaitForSeconds(0.05f);
			//���ɖ߂�
			GetComponent<Renderer>().material.color =  new Color(1, 1, 1, 1);
			//0.05�b�҂�
			yield return new WaitForSeconds(0.05f);
			count--;
		}
		//���C���[��Player�ɖ߂�
		this.gameObject.layer = LayerMask.NameToLayer("player");
		
	}
	//********** �I�� **********//
}