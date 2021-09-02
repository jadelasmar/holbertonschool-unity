using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController characterController;
    public float speed = 10.0f;
    public float jumpSpeed = 10.0f;
    public float gravity = 20.0f;


    private Vector3 moveDirection = Vector3.zero;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, 0, vertical) * (speed * Time.deltaTime));

        if (characterController.isGrounded)
        {

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);
    }
}