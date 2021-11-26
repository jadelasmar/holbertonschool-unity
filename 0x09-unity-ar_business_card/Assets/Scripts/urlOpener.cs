using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class urlOpener : MonoBehaviour
{
    public VirtualButtonBehaviour gitVb;
    public VirtualButtonBehaviour linkVb;
    public VirtualButtonBehaviour numVb;
    public VirtualButtonBehaviour instVb;
    public VirtualButtonBehaviour gmailVb;
    public Animator anim;

    private void Start()
    {
        gitVb.RegisterOnButtonPressed(gitUrl);
        linkVb.RegisterOnButtonPressed(linkUrl);
        numVb.RegisterOnButtonPressed(numUrl);
        instVb.RegisterOnButtonPressed(instUrl);
        gmailVb.RegisterOnButtonPressed(gmailUrl);
    }

    public void gitUrl(VirtualButtonBehaviour gitVb)
    {
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            Application.OpenURL("https://github.com/jadelasmar");
            Debug.Log("git");
        }
    }

    public void linkUrl(VirtualButtonBehaviour linkVb)
    {
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            Application.OpenURL("https://linkedin.com/in/jad-elasmar-16b075202/");
            Debug.Log("link");
        }
    }

    public void numUrl(VirtualButtonBehaviour numVb)
    {
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            Application.OpenURL("tel://[+96176463616]");
            Debug.Log("num");
        }
    }

    public void instUrl(VirtualButtonBehaviour instVb)
    {
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            Application.OpenURL("https://instagram.com/jad.elasmar/");
            Debug.Log("insta");
        }
    }

    public void gmailUrl(VirtualButtonBehaviour gmailVb)
    {
        if (anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            Application.OpenURL("mailto:el.asmar.jad.94@gmail.com");
            Debug.Log("gmail");
        }
    }
}