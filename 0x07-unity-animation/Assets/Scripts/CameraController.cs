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
        

        //initial camera position
        offset = new Vector3(0f, 1.5f, -7f);

        //check if invertedY is on/off
        if (PlayerPrefs.GetInt("invertedY") == 1)
            isInverted = true;
        else
            isInverted = false;
    }
    void LateUpdate()
    {
        
        if (Input.GetMouseButton(1))
        {
            transform.position = player.transform.position + offset;
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up * Time.deltaTime) * offset;
            offset = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * -turnSpeed, Vector3.right * Time.deltaTime * (isInverted ? -1 : 1)) * offset;
        }
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform.position);
    }
}