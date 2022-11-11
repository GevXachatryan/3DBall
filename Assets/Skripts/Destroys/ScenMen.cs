using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenMen : MonoBehaviour
{


    public GameObject GameOverUI;

    public Rigidbody rb;

    public GameObject pause;
    public GameObject maniu;






    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Mir" || other.tag == "DestroysObjs")
        {
            // GameOver.Play();
            //  losePanel.SetActive(true);
            // Time.timeScale = 0;
            pause.SetActive(false);
            maniu.SetActive(true);

            rb.isKinematic = true;
            GameOverUI.SetActive(true);

        }

    }

 public void RestScen()
    {
        //SceneManager.LoadScene(0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
