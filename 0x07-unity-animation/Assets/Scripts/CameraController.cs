using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    private float turnSpeed = 3f;
    public bool isInverted;
    void Start()
    {
        offset = new Vector3(0f, 1.5f, -7f);
        if (PlayerPrefs.GetInt("invertedY") == 1)
        {
            isInverted = true;
        }
        else
        {
            isInverted = false;
        }
    }
    void LateUpdate()
    {
        if (isInverted == true)
        {
            if (Input.GetMouseButton(1))
            {
                offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * Quaternion.AngleAxis((Input.GetAxis("Mouse Y") * -1) * turnSpeed, Vector3.left) * offset;
                transform.position = player.transform.position + offset;

                transform.LookAt(player.transform.position);
            }
            else
            {
                transform.position = player.transform.position + offset;
            }
        }
        else
        {
            if (Input.GetMouseButton(1))
            {
                offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * turnSpeed, Vector3.left) * offset;
                transform.position = player.transform.position + offset;

                transform.LookAt(player.transform.position);
            }
            else
            {
                transform.position = player.transform.position + offset;
            }
        }
    }
}