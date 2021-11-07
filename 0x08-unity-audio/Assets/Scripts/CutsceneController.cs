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
    private MusicScript musicScript;


    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        playerController = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
        musicScript = GameObject.Find("BGM").GetComponent<MusicScript>();

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