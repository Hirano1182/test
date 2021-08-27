using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_Lifecount : MonoBehaviour
{
	public string targetObjectName; // �ڕW�I�u�W�F�N�g���FInspector�Ŏw��
	public int addValue = 1;    // �����ʁFInspector�Ŏw��
	private AudioSource sound01;

	void Start()
	{ 
		AudioSource[] audioSources = GetComponents<AudioSource>();
		sound01 = audioSources[1];
	}


	void OnCollisionEnter2D(Collision2D collision)
	{ // �Փ˂����Ƃ�
	  // �����A�Փ˂������̖̂��O���ڕW�I�u�W�F�N�g��������
		if (collision.gameObject.name == targetObjectName)
		{
			sound01.PlayOneShot(sound01.clip);
			LifeCounter_plus.life = LifeCounter_plus.life + addValue;
		}
	}
}
