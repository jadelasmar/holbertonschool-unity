using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Buttons : MonoBehaviour
{
    public VirtualButtonBehaviour vb;
    
    void Start()
    {
        vb.RegisterOnButtonReleased(onButtonReleased);
    }

    private void Update()
    {
        
    }

    public void onButtonReleased(VirtualButtonBehaviour vb)
    {
        Application.OpenURL("https://github.com/jadelasmar");
        Debug.Log("giiiit");
    }
}