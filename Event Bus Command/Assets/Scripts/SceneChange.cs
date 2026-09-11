using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void OnGUI()
    {
        if(GUI.Button(new Rect(0, 100, 80, 25), "Next Scene"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        // if(GUI.Button(new Rect(0, 120, 80, 25), "Previous Scene"));
        // {
        //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        // }    
    }
}
