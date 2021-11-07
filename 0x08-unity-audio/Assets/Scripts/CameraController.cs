using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public bool inputEnabled = true;
    public bool isInverted;

    [Range(1, 10)] public float sensitivity = 5.0f;

    private Vector3 cameraOffset;
    private float mouseX;
    private float mouseY;

    private void Start()
    {
        // Take camera offset based on initial position of player and camera
        cameraOffset = player.position - transform.position;

        // Check settings for Y axis inversion.
        isInverted = PlayerPrefs.GetInt(PlayerPrefKeys.invertY) == 1 ? true : false;
    }

    private void LateUpdate()
    {
        if (inputEnabled)
            GetMouseInput();
    }

    private void GetMouseInput()
    {
        if (Input.GetButton("ClickToRotate"))
        {
            mouseX += Input.GetAxis("Mouse X") * sensitivity;
            mouseY += Input.GetAxis("Mouse Y") * (isInverted ? -1 : 1) * sensitivity;
        }

        // Get new rotation based on mouse input.
        var rotation = Quaternion.Euler(mouseY, mouseX, 0f);

        // Position camera based on rotation, offset and current player position.
        transform.position = player.transform.position - rotation * cameraOffset;

        // Rotate camera to always look at player
        transform.LookAt(player.position);
    }
}