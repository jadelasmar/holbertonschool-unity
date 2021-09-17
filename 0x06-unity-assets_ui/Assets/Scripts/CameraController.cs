using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    private float turnSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0f, 1.5f, -7f);

    }

    void Update()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Cursor.lockState = CursorLockMode.Locked;
        transform.position = player.transform.position + offset;
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * -turnSpeed, Vector3.right) * offset;
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform.position);

    }
}