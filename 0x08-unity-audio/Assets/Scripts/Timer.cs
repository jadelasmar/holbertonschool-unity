using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public Text finalTime;
    private CameraController cameraController;
    private float minutes;
    private PlayerController playerController;
    private float seconds;
    private float time;
    private bool timerIsRunning;

    // Stop timer and reset time to zero
    public void Reset()
    {
        timerIsRunning = false;
        time = minutes = seconds = 0;
        timerText.text = "0:00.00";
        timerText.color = Color.white;
        timerText.fontSize = 48;
    }


    private void Start()
    {
        playerController = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
        cameraController = GameObject.FindWithTag("MainCamera").GetComponent<CameraController>();
    }

    private void Update()
    {
        if (timerIsRunning)
        {
            time += Time.deltaTime;

            if (time >= 60.00f)
            {
                minutes++;
                seconds = time;
                time = 0;
            }

            if (minutes >= 60)
                minutes = 0;

            timerText.text = $"{minutes.ToString()}:{time.ToString("00.##")}";
        }
    }

    public void Run()
    {
        timerIsRunning = true;
    }

    public void Pause()
    {
        timerIsRunning = false;
    }

    public void Win()
    {
        Pause();

        // Disable player input controls and zero-out velocity.
        playerController.inputEnabled = false;
        playerController.velocity = Vector3.zero;
        cameraController.inputEnabled = false;
        Cursor.visible = true;

        finalTime.text = $"{minutes.ToString()}:{time.ToString("00.##")}";
    }
}