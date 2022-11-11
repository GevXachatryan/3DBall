using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Paus_Load : MonoBehaviour
{
    public GameObject Maniu;
    public GameObject Paus;
    public GameObject Play;

  

    static bool truE = true;
    static bool falsE = false;


   









    public void pause()
    {
        if(truE)
        {
            
            Paus.SetActive(falsE);
            Play.SetActive(truE);
            Maniu.SetActive(truE);
            Time.timeScale = 0;

            
        }
       
       
    }







    public void play()
    {
        if (truE)
        {
            Maniu.SetActive(falsE);
            Play.SetActive(falsE);
            Paus.SetActive(truE);
            Time.timeScale = 1;
        }
       
    }





    public void meniu()
    {
        SceneManager.LoadScene(0);
    }

}
