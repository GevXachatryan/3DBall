using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
   public GameObject levlPerexod_UI;
    public Rigidbody rb;
    public int nextScenLoad;

    void Start()
    {
        nextScenLoad = SceneManager.GetActiveScene().buildIndex + 1;
        Moneti.coins = 0;
    }

    private void Update()
    {
        levlPerexod();


       
    }

public void levlPerexod()
    {

        if (Moneti.coins == 20)
        {
            levlPerexod_UI.SetActive(true);
            rb.isKinematic = true;
           

            if (SceneManager.GetActiveScene().buildIndex == 10)
            {
                SceneManager.LoadScene(11);
            }
            else
            {

              //  SceneManager.LoadScene(nextScenLoad);

                if (nextScenLoad > PlayerPrefs.GetInt("levelAt"))
                {
                    PlayerPrefs.SetInt("levelAt", nextScenLoad);
                }
            }

        }

    }






    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        if (SceneManager.GetActiveScene().buildIndex == 10)
    //        {
    //            SceneManager.LoadScene(0);
    //        }
    //        else
    //        {

    //            SceneManager.LoadScene(nextScenLoad);

    //            if (nextScenLoad > PlayerPrefs.GetInt("levelAt"))
    //            {
    //                PlayerPrefs.SetInt("levelAt", nextScenLoad);
    //            }
    //        }


    //    }
    //}
}
