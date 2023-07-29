using BrewedInk.CRT;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableCRT : MonoBehaviour
{
    // Reference to the script you want to disable
    public CRTCameraBehaviour crtScriptComponent;

    public void Update()
    {
        CheckDisableScript();
    }

    [NaughtyAttributes.Button]
    public void CheckDisableScript()
    {
        if (MainManager.Instance.CRTEffect == false)
        {
            crtScriptComponent.enabled = false;
        }
    }
}