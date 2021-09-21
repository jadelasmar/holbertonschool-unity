using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseCanvas;
    public bool gamePaused = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused == true)
                Resume();
            else
                Pause();
        }
    }
    public void Pause()
    {
        pauseCanvas.SetActive(true);
        Time.timeScale = 0;
        gamePaused = true;   
        
    }
    public void Resume()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1;
        gamePaused = false;
    }
}
