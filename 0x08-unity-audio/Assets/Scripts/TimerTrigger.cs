using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    private Timer timer;

    private void Start()
    {
        timer = GameObject.FindWithTag("Player").GetComponent<Timer>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            EnableTimer();
    }

    private void EnableTimer()
    {
        timer.enabled = true;
        timer.Run();
    }
}