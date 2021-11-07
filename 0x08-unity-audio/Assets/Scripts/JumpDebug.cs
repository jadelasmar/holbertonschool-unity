using UnityEngine;
using UnityEngine.UI;

public class JumpDebug : MonoBehaviour
{
    public Text debugText;
    private float jumpTimer;
    private float jumpVelocity;
    private PlayerController player;
    private string textUpdate;

    // Start is called before the first frame update
    private void Start()
    {
        player = gameObject.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    private void Update()
    {
        textUpdate =
            $"Jump Timer: {player.jumpTimer.ToString("F2")}\nJump Velocity: {player.velocity.y.ToString("F2")}";
        debugText.text = textUpdate;
    }
}