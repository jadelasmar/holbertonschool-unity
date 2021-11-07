﻿using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public Text timerText;
    public GameObject winCanvas;
    private Timer timer;
    public MusicScript musicScript;


    private void Start()
    {
        timer = GameObject.FindWithTag("Player").GetComponent<Timer>();
        musicScript = GameObject.Find("BGM").GetComponent<MusicScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            timer.Win();
            timerText.enabled = false;
            winCanvas.SetActive(true);
            musicScript.stopBGM();
        }
    }
}