using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    private Timer timer;
    private PlayerController playerController;

    void Start()
    {
        timer = GameObject.FindWithTag("Player").GetComponent<Timer>();
        playerController = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && playerController.enabled == true)
            EnableTimer();
    }

    private void EnableTimer()
    {
        timer.enabled = true;
        timer.Run();
    }
}