using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
	public string targetObjectName;
	public string targetObjectName2;
	public string showObjectName;
	bool a = false;
	bool b = false;// �\���I�u�W�F�N�g���FInspector�Ŏw��

	GameObject showObject;

	void Start()
	{ // �ŏ��ɍs��
	  // �����O�ɕ\���I�u�W�F�N�g���o���Ă�����
		// ����
	}

	void FixedUpdate()
	{ // �����ƍs���i��莞�Ԃ��ƂɁj
	  // �J�E���^�[���ŏI�l�ɂȂ�����
		if (a == true && b == true)
		{
			Time.timeScale = 0; // ���Ԃ��~�߂�
		}
	}

	void OnCollisionEnter2D(Collision2D collision)
	{ // �Փ˂����Ƃ�
	  // �����A�Փ˂������̖̂��O���ڕW�I�u�W�F�N�g��������
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
