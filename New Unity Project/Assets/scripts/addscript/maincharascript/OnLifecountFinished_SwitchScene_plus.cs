using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnLifecountFinished_SwitchScene_plus : MonoBehaviour
{
    public int lastCount = 0; 
    public string sceneName = "";
	public string showObjectName = "";   // �\���I�u�W�F�N�g���FInspector�Ŏw��
	public string targetObjectName;

	GameObject showObject;
	GameObject gameObject1;

	void Start()
    {
		GameObject.Find("Canvas").transform.Find("gameover").gameObject.SetActive(false);
		gameObject1 = GameObject.Find(targetObjectName);
		// ����
	}

	void FixedUpdate(){ 
	  
		if (LifeCounter_plus.life == lastCount){

			GameObject.Find("Canvas").transform.Find("gameover").gameObject.SetActive(true);
			gameObject1.GetComponent<OnKeyPress_MoveGravityPlus>().enabled = false;

			Invoke(nameof(Damage), 3.0f);
			
		}
	}
	void Damage()
	{
		
		GameObject.Find("Canvas").transform.Find("RETRY").gameObject.SetActive(true);
		GameObject.Find("Canvas").transform.Find("TYTLE").gameObject.SetActive(true);
		Time.timeScale = 0;
	}

	void OnDestroy()
	{
		CancelInvoke();
	}
}