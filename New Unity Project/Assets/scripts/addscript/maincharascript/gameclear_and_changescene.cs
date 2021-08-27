using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameclear_and_changescene : MonoBehaviour
{
    public string target;
    public string sceneName;
    public string objectname;
    public int check;
    GameObject gameObject1;


    Vector3 base_pos;

    void Start()
    {
        gameObject1 = GameObject.Find(objectname);
       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == target)
        {
            check++;
           gameObject1.GetComponent<OnKeyPress_MoveGravityPlus>().enabled = false;
            Invoke(nameof(Damage), 3.0f);

        }
    }
	void Damage()
	{
       
        check++;
        SceneManager.LoadScene(sceneName);
        Vector3 pos = this.transform.position;
        Camera.main.gameObject.transform.position = pos;
    }

    void OnDestroy()
    {
        CancelInvoke();
    }
	
		
}

