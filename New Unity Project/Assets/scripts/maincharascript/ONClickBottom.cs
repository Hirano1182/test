using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OnClickBottom : MonoBehaviour
{
    public string showObjectName1;
    public string showObjectName2;

    GameObject showObject1;
    GameObject showObject2;
    bool flag;
    // Start is called before the first frame update
    void Start()
    { // 最初に行う
      // 消す前に表示オブジェクトを覚えておいて
        showObject1 = GameObject.Find(showObjectName1);
        showObject1.SetActive(false);
        showObject2 = GameObject.Find(showObjectName2);
        showObject2.SetActive(false);
        flag = false;
    }

    public void OnClick()
    {
        if (flag == true)
        {
            flag = false;
            GameObject.Find("Canvas").transform.Find("RETRY").gameObject.SetActive(false);
            GameObject.Find("Canvas").transform.Find("TYTLE").gameObject.SetActive(false);
            Time.timeScale = 1;
        }
        else
        {
            flag = true;
            GameObject.Find("Canvas").transform.Find("RETRY").gameObject.SetActive(true);
            GameObject.Find("Canvas").transform.Find("TYTLE").gameObject.SetActive(true);
            Time.timeScale = 0;
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
