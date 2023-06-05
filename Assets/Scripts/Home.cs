using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public Text coinTxt;
    public bool inStore;
    // Start is called before the first frame update
    void Start()
    {
        if (inStore)
        {
            int totalCoins = PlayerPrefs.GetInt("coin");
            coinTxt.text = "" + totalCoins;
        }
        

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
