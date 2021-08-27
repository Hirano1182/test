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
		//Enemyとぶつかった時にコルーチンを実行
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
		//レイヤーをPlayerDamageに変更
		this.gameObject.layer = LayerMask.NameToLayer("playerdamage");
		//while文を10回ループ
		int count = 15;
		while (count > 0)
		{
			//透明にする
			GetComponent<Renderer>().material.color = Color.red;

			//0.05秒待つ
			yield return new WaitForSeconds(0.05f);
			//元に戻す
			GetComponent<Renderer>().material.color =  new Color(1, 1, 1, 1);
			//0.05秒待つ
			yield return new WaitForSeconds(0.05f);
			count--;
		}
		//レイヤーをPlayerに戻す
		this.gameObject.layer = LayerMask.NameToLayer("player");
		
	}
	//********** 終了 **********//
}