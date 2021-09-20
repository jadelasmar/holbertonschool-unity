using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /// <summary>
    /// method for selecting levels
    /// </summary>
    /// <param name="level"></param>
    public void LevelSelect(int level)
    {
        SceneManager.LoadScene(level);
    }
   
}
