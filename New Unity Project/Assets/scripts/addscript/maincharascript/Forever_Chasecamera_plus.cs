using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �����ƁA�J�������ǂ�������i�����Ɂj
public class Forever_Chasecamera_plus : MonoBehaviour
{
	public int StartPos;
	public int GoalPos;
	Vector3 base_pos;

	void Start()
	{ // �ŏ��ɍs��
	  // �J�����̌��̈ʒu���o���Ă���
		base_pos = Camera.main.gameObject.transform.position;
	}

	void LateUpdate()
	{ // �����ƍs���i���낢��ȏ����̍Ō�Ɂj
		if (this.transform.position.x >= StartPos && this.transform.position.x <= GoalPos)
		{
			Vector3 pos = this.transform.position; // �����̈ʒu
			pos.z = -10; // �J�����Ȃ̂Ŏ�O�Ɉړ�������
			pos.y = base_pos.y; // �J�����̌��̍������g��
			Camera.main.gameObject.transform.position = pos;
		}
	}
}