using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGamer : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void maniu()
    {
        SceneManager.LoadScene(0);
    }
}
