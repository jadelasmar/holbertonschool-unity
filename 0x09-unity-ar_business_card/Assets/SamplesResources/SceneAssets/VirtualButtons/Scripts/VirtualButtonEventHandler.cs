/*========================================================================
Copyright (c) 2021 PTC Inc. All Rights Reserved.
 
Confidential and Proprietary - Protected under copyright and other laws.
Vuforia is a trademark of PTC Inc., registered in the United States and other
countries.
=========================================================================*/

using System.Collections;
using UnityEngine;
using Vuforia;

/// <summary>
/// This class implements the IVirtualButtonEventHandler interface and
/// contains the logic to start animations depending on what 
/// virtual button has been pressed.
/// </summary>
public class VirtualButtonEventHandler : MonoBehaviour
{
    public Material VirtualButtonDefault;
    public Material VirtualButtonPressed;
    public float ButtonReleaseTimeDelay;

    VirtualButtonBehaviour[] mVirtualButtonBehaviours;

    void Awake()
    {
        // Register with the virtual buttons ObserverBehaviour
        mVirtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (var i = 0; i < mVirtualButtonBehaviours.Length; ++i)
        {
            mVirtualButtonBehaviours[i].RegisterOnButtonPressed(OnButtonPressed);
            mVirtualButtonBehaviours[i].RegisterOnButtonReleased(OnButtonReleased);
        }
    }

    void Destroy()
    {
        // Register with the virtual buttons ObserverBehaviour
        mVirtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (var i = 0; i < mVirtualButtonBehaviours.Length; ++i)
        {
            mVirtualButtonBehaviours[i].UnregisterOnButtonPressed(OnButtonPressed);
            mVirtualButtonBehaviours[i].UnregisterOnButtonReleased(OnButtonReleased);
        }
    }

    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        SetVirtualButtonMaterial(VirtualButtonPressed);
        StopAllCoroutines();
        BroadcastMessage("HandleVirtualButtonPressed", SendMessageOptions.DontRequireReceiver);
        
        if (vb.name == "GithubScan")
            Application.OpenURL("https://github.com/jadelasmar");
        else if (vb.name == "GmailScan")
            Application.OpenURL("mailto:el.asmar.jad.94@gmail.com");
        else if (vb.name == "NumberScan")
            Application.OpenURL("tel://[+96176463616]");
        else if (vb.name == "LinkedInScan")
            Application.OpenURL("https://linkedin.com/in/jad-elasmar-16b075202/");
        else if (vb.name == "InstaScan")
            Application.OpenURL("https://instagram.com/jad.elasmar/");
    }

    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("OnButtonReleased: " + vb.VirtualButtonName);
        SetVirtualButtonMaterial(VirtualButtonDefault);
        StartCoroutine(DelayOnButtonReleasedEvent(ButtonReleaseTimeDelay));
    }

    void SetVirtualButtonMaterial(Material material)
    {
        // Set the Virtual Button material
        for (var i = 0; i < mVirtualButtonBehaviours.Length; ++i)
        {
            if (material != null)
                mVirtualButtonBehaviours[i].GetComponent<MeshRenderer>().sharedMaterial = material;
        }
    }

    IEnumerator DelayOnButtonReleasedEvent(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        BroadcastMessage("HandleVirtualButtonReleased", SendMessageOptions.DontRequireReceiver);
    }
}