using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class   Forever_ShowLifecount : MonoBehaviour
{
  

    
    void Update()
    {
        GetComponent<Text>().text = LifeCounter_plus.life.ToString();
    }
}
