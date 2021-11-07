using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject timerCanvas;
    public GameObject menuController;
    public string animationName;
    public bool skipAnimation;
    private Animator animator;
    private PlayerController playerController;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        playerController = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
    }

    private void Update()
    {
        if (skipAnimation || !animator.GetCurrentAnimatorStateInfo(0).IsName(animationName))
        {
            mainCamera.SetActive(true);
            playerController.enabled = true;
            menuController.SetActive(true);
            timerCanvas.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}