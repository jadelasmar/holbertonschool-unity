using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseCanvas;
    public GameObject Camera;
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
        PauseCanvas.SetActive(true);
        Camera.SetActive(false);
        Time.timeScale = 0f;
        gamePaused = true;
    }
    public void Resume()
    {
        PauseCanvas.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }
}
