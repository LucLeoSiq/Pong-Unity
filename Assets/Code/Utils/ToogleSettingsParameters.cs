using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToogleSettingsParameters : MonoBehaviour
{
    public void ToogleCRTBool()
    {
        if (MainManager.Instance.CRTEffect == true) MainManager.Instance.CRTEffect = false;
        else if (MainManager.Instance.CRTEffect == false) MainManager.Instance.CRTEffect = true;
    }

    public void ToogleMuteBool()
    {
        if (MainManager.Instance.MuteGame == true) MainManager.Instance.MuteGame = false;
        else if (MainManager.Instance.MuteGame == false) MainManager.Instance.MuteGame = true;
    }
}
