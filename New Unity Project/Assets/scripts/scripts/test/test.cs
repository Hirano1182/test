using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
	public string targetObjectName;
	public string targetObjectName2;
	public string showObjectName;
	bool a = false;
	bool b = false;// 表示オブジェクト名：Inspectorで指定

	GameObject showObject;

	void Start()
	{ // 最初に行う
	  // 消す前に表示オブジェクトを覚えておいて
		// 消す
	}

	void FixedUpdate()
	{ // ずっと行う（一定時間ごとに）
	  // カウンターが最終値になったら
		if (a == true && b == true)
		{
			Time.timeScale = 0; // 時間を止める
		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{ // 衝突したとき
	  // もし、衝突したものの名前が目標オブジェクトだったら
		if (collision.gameObject.name == targetObjectName)
        {
			a = true;
        }
		if (collision.gameObject.name == targetObjectName2)
		{
			b = true;
			
		}

	}
	void OnCollisionExit2D(Collision2D collision)
    {
		if (collision.gameObject.name == targetObjectName)
		{
			a = false;
		}
		if (collision.gameObject.name == targetObjectName2)
		{
			b = false;

		}
	}
}
