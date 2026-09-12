using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Command");
    }

    public void PreviousScene()
    {
        SceneManager.LoadScene("Event Bus");
    }
}
