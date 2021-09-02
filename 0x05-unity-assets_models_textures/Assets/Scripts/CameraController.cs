using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform t;
    private Vector3 offset;

    public GameObject player;
    public float mouseSpeed = 5.0f;


    void Start()
    {
        offset = transform.position - player.transform.position;
    }


    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * mouseSpeed, Vector3.up) * Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * mouseSpeed, Vector3.left) * offset;
            transform.position = player.transform.position + offset;
            transform.LookAt(player.transform.position);
        }
        else
        {
            transform.position = player.transform.position + offset;
        }
    }
}