using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeImage : MonoBehaviour
{
    private Image img = null;
    private float timer = 0.0f;
    private int framecount = 0;
    private bool fadein = false;
    void Start()
    {
        img = GetComponent<Image>();
        img.color = new Color(1, 1, 1, 1);
        img.fillAmount = 1;
        img.raycastTarget = true;
        fadein = true;
    }

    void Update()
    {
        if(framecount > 2)
        {
            if (fadein)
            {
                if(timer < 1)
                {
                    img.color = new Color(1, 1, 1, 1 - timer);
                    img.fillAmount = 1 - timer;
                }
                else
                {
                    img.color = new Color(1, 1, 1, 0);
                    img.fillAmount = 0;
                    img.raycastTarget = false;
                    timer = 0.0f;
                    fadein = false;
                }
                timer += Time.deltaTime;
            }
        }
        ++framecount;
    }

}