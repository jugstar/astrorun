using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play()
    {
        if (setting.sound)
            soundScript.vol = 1;
        else
        {
            soundScript.vol = 0;
        }
        SceneManager.LoadScene(3);
    }

    public void settings()
    {
        SceneManager.LoadScene(1);
    }

    public void store()
    {
        SceneManager.LoadScene(2);
    }

    public void back()
    {
        SceneManager.LoadScene(0);
    }
}
