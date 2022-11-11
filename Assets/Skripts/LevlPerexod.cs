using UnityEngine;
using UnityEngine.SceneManagement;
public class LevlPerexod : MonoBehaviour
{
   

    public void LoadScene()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        
    }
}
