using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public Text time;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<Timer>().enabled = false;
            time.fontSize = 150;
            time.color = Color.green;

        }
    }
}
