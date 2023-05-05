using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setting : MonoBehaviour
{
    public Button soundBtn;
    public static bool sound = true;
    public Sprite on, off;

    public Button musicBtn;
    public static bool musicsound = true;
    public Sprite musicon, musicoff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!sound)
        {
            soundBtn.image.sprite = off;
            soundScript.vol = 0;
        }
        if (sound)
        {
            soundBtn.image.sprite = on;
            soundScript.vol = 1;
        }


        if (!musicsound)
        {
            musicBtn.image.sprite = musicoff;
            
        }
        if (musicsound)
        {
            musicBtn.image.sprite = musicon;
           
        }

    }

    public void sBtn()
    {
        sound = !sound;
    }

    public void mBtn()
    {
        musicsound = !musicsound;
    }

}
