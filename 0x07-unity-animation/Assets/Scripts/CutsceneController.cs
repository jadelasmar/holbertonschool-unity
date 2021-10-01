using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    private Animator animator;
    public string animationName;
    public GameObject mainCamera;
    public GameObject timerCanvas;
    private PlayerController playerController;

    public void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        playerController = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
    }

    public void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName(animationName) && animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            gameObject.SetActive(false);
            mainCamera.SetActive(true);
            timerCanvas.SetActive(true);
            playerController.enabled = true;
        }
    }
}