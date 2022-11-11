using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManiu : MonoBehaviour
{
        
    public Button[] buttons;


    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 1);

        for (int i = 0; i < buttons.Length; i++)
        {
            if (i + 1 > levelAt)
            {
                buttons[i].interactable = false;
            }
        }




    }

    public void luadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
        Time.timeScale = 1;

    }



    public void manyu()
    {
        SceneManager.LoadScene(0);
    }


    public void restartLvl()
    {
        PlayerPrefs.DeleteAll();
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
            buttons[0].interactable = true;
        }

    }
}
