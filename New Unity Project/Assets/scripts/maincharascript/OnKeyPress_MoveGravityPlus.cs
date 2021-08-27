using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �L�[�������ƁA�ړ�����i�d�͑Ή��Łj
public class OnKeyPress_MoveGravityPlus : MonoBehaviour
{

	public float speed = 3; // �X�s�[�h�FInspector�Ŏw��
	public float jumppower = 8;  // �W�����v�́FInspector�Ŏw��
	public float rotateAngle = 0;

	float vx = 0;
	bool leftFlag = false; // ���������ǂ���
	bool pushFlag = false; // �X�y�[�X�L�[���������ςȂ����ǂ���
	bool jumpFlag = false; // �W�����v��Ԃ��ǂ���
	bool groundFlag = false; // ���������ɐG��Ă��邩�ǂ���
	public int secondjump = 0;
	Rigidbody2D rbody;
	private AudioSource sound01;

	void Start()
	{ // �ŏ��ɍs��
	  // �Փˎ��ɉ�]�����Ȃ�
		rbody = GetComponent<Rigidbody2D>();
		rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
		AudioSource[] audioSources = GetComponents<AudioSource>();
		sound01 = audioSources[0];
	}

	void Update()
	{ // �����ƍs��
		if(groundFlag)
        {
			secondjump = 0;
        }
		vx = 0;
		if (Input.GetKey("right"))
		{ // �����A�E�L�[�������ꂽ��
			vx = speed; // �E�ɐi�ވړ��ʂ�����
			leftFlag = false;
		}
		if (Input.GetKey("left"))
		{ // �����A���L�[�������ꂽ��
			vx = -speed; // ���ɐi�ވړ��ʂ�����
			leftFlag = true;
		}
		
		// �����A�X�y�[�X�L�[�������ꂽ�Ƃ��A���������ɐG��Ă�����
		if (Input.GetKeyDown("space") && groundFlag)
		{
			
			if (pushFlag == false)
			{ // �������ςȂ��łȂ����
				secondjump++;
				jumpFlag = true; // �W�����v�̏���
				pushFlag = true; // �������ςȂ����
				sound01.PlayOneShot(sound01.clip);
			}
		}
		else
		{
			pushFlag = false; // �������ςȂ�����
		}
		if (Input.GetKeyDown("space") && groundFlag == false )
		{

			if (pushFlag == false && secondjump <= 0)
			{ // �������ςȂ��łȂ����
				
				jumpFlag = true; // �W�����v�̏���
				pushFlag = true; // �������ςȂ����
				secondjump++;
				sound01.PlayOneShot(sound01.clip);


			}
		}
		else
		{
			pushFlag = false; // �������ςȂ�����
		}


	}

	void FixedUpdate()
	{ // �����ƍs���i��莞�Ԃ��ƂɁj
	  // �ړ�����i�d�͂��������܂܁j
		rbody.velocity = new Vector2(vx, rbody.velocity.y);
		// ���E�Ɍ�����ς���
		this.GetComponent<SpriteRenderer>().flipX = leftFlag;
		// �����A�W�����v����Ƃ�
		if (jumpFlag)
		{
			jumpFlag = false;
			rbody.AddForce(new Vector2(0, jumppower), ForceMode2D.Impulse);
		
		}
	}
	void OnTriggerStay2D(Collider2D collision)
	{ // ���������ɐG�ꂽ��
		groundFlag = true;
		
	}
	void OnTriggerExit2D(Collider2D collision)
	{ // ���ɉ����G��Ȃ�������
		groundFlag = false;
	}
}