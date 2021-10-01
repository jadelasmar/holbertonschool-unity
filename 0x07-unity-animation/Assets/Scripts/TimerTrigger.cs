using UnityEngine;

public class TimerTrigger : MonoBehaviour
{

    private PlayerController playerController;
    void Start()
    {
        playerController = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && playerController.enabled == true)
        {
            other.gameObject.GetComponent<Timer>().enabled = true;
        }
    }
}