using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Src_Title : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Press_Play()
    {
        SceneManager.LoadScene("Scene_Game");
    }

    public void Press_Exit()
    {
        Application.Quit();
    }

}
