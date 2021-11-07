using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform playerCamera;
    private CharacterController controller;
    public float yBounds = -30f;
    public float walkSpeed = 10f;
    public float gravity = 1f;

    [Range(0, 300)]
    public float rotateSpeed = 150f;

    [Range(0, 30)]
    public float jumpHeight = 12f;
    private Vector3 jumpVelocity;
    private bool isJumping = false;
    public Vector3 velocity = new Vector3(0, 0, 0);
    public bool inputEnabled = true;
    private Animator animator;


    void Start()
    {
        // Assign character controller component.
        controller = gameObject.GetComponent<CharacterController>();
        animator = transform.GetChild(0).GetComponent<Animator>();
    }

    void Update()
    {
        // Rotates player transform according to the mouse X axis.
        if (inputEnabled)
            transform.Rotate(0f, Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime, 0f);

        // New movement input is applied to the velocity variable.
        MovePlayer();
        // Check if player is out of bounds.
        if (transform.position.y < yBounds)
        {
            RespawnPlayer();
        }

        //not working
        /*
        if (controller.isGrounded)
            animator.SetBool("isFalling", false);
        else animator.SetBool("isFalling", true);
        */


    }

    private void MovePlayer()
    {
        // Grounded movement
        if (controller.isGrounded)
        {
            // Assign default Y velocity for grounded state.
            // This helps avoid issues with ground detection and mesh overlap.


            // Get left/right/forward/backward input
            if (inputEnabled)
            {
                velocity.x = Input.GetAxis("Horizontal") * walkSpeed;
                velocity.z = Input.GetAxis("Vertical") * walkSpeed;
            }
        }
        else // Airborne movement
            // Apply gravity effect to player's Y velocity.
            ApplyGravity();

        GetJump(); // Checks and applies jump input to Y velocity.

        // Convert local space movement to world space vector.
        Vector3 move = transform.TransformDirection(velocity);

        // Apply movement to character controller, if there's movement to apply.
        if (move.magnitude >= 0.01f)
        {
            controller.Move(move * Time.deltaTime);
            if (Input.GetKey("a") || Input.GetKey("d") || Input.GetKey("s") || Input.GetKey("w"))
            {
                animator.SetBool("isRunning", true);
            }
            else animator.SetBool("isRunning", false);
        }

    }

    private void GetJump()
    {
        // Get input to initiate base jump mechanic.
        if (inputEnabled && Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            isJumping = true;
            velocity.y = jumpHeight;
            animator.SetTrigger("isJumping");

            // Strip current velocity vector of speed scalar when recording jump velocity.
            // jumpVelocity stores an initial jump trajectory which can be altered combined
            // with any new X/Z movement controls received while player is still airborne.
            jumpVelocity = new Vector3(velocity.x / walkSpeed, velocity.y, velocity.z / walkSpeed);
        }
    }

    private void ApplyGravity()
    {
        if (velocity.y >= -30) // -30 represents maximum downward velocity allowed.
        {
            // As jump approaches and passes peak, exponentially increase fall velocity.
            // This provides a jump arc that curves more dramatically past its peak.
            if (isJumping && velocity.y < 1.4)
                velocity.y += -gravity * 1.4f;
            else // Gravity application for a non-jump-induced airborne state.
                velocity.y += -gravity;
        }
    }

    private void RespawnPlayer()
    {
        //Respawn player to initial position
        transform.position = new Vector3(0f, 30f, 0f);
        velocity = Vector3.zero;
    }
}