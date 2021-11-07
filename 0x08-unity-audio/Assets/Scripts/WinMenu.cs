using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Next()
    {
        var currentScene = SceneManager.GetActiveScene().buildIndex;
        var nextScene = currentScene != 3 ? currentScene + 1 : 0;

        SceneManager.LoadScene(nextScene);
    }
}