using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject winCanvas;
    private CameraController cameraController;
    private bool isPaused;
    private PlayerController playerController;
    private Timer timer;
    public MusicScript musicScript;


    private void Start()
    {
        timer = GameObject.FindWithTag("Player").GetComponent<Timer>();
        playerController = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
        cameraController = GameObject.FindWithTag("MainCamera").GetComponent<CameraController>();
        musicScript = GameObject.Find("BGM").GetComponent<MusicScript>();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !winCanvas.activeSelf)
        {
            if (isPaused)
                Resume();
            else
                Pause();
        }
    }

    public void Pause()
    {
        // Pause timer if reference is held.
        if (timer != null)
            timer.Pause();

        // Disable player input controls and zero-out velocity.
        playerController.inputEnabled = false;
        playerController.velocity = Vector3.zero;
        cameraController.inputEnabled = false;

        // Set menu canvas to appear.
        menu.SetActive(true);
        
        // Reveal cursor.
        Cursor.visible = true;

        isPaused = true;
        musicScript.pauseSnap();
    }

    public void Resume()
    {
        // Set menu canvas to disappear.
        menu.SetActive(false);

        // Restore player input controls.
        playerController.inputEnabled = true;
        cameraController.inputEnabled = true;

        // Run timer.
        if (timer != null)
            timer.Run();

        // Hide cursor.
        Cursor.visible = false;

        isPaused = false;
        musicScript.resumeSnap();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Options()
    {
        // Save current scene to PlayerPrefs for back reference.
        PlayerPrefs.SetInt(PlayerPrefKeys.previousScene, SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(4);
    }
}