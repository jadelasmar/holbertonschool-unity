using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public Text timerText;
    public GameObject winCanvas;
    private Timer timer;


    private void Start()
    {
        timer = GameObject.FindWithTag("Player").GetComponent<Timer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            timer.Win();
            timerText.enabled = false;
            winCanvas.SetActive(true);
        }
    }
}