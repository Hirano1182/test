using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Iffalled_GameOver : MonoBehaviour
{
    public string targetObjectName;
    GameObject gameObject1;

    // Start is called before the first frame update
    void Start()
    {
        gameObject1 = GameObject.Find(targetObjectName);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            GameObject.Find("Canvas").transform.Find("gameover").gameObject.SetActive(true);
            gameObject1.GetComponent<OnKeyPress_MoveGravityPlus>().enabled = false;
            Invoke(nameof(Damage), 3.0f);

        }
    }

    void Damage()
    {
        GameObject.Find("Canvas").transform.Find("RETRY").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("TYTLE").gameObject.SetActive(true);
    }

    void OnDestroy()
    {
        CancelInvoke();
    }


}
