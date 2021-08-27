using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClick_Changescene : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    public void OnClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName);
    }

    
}
