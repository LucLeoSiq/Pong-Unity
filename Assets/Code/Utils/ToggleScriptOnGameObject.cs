using UnityEngine;

public class ToggleScriptOnGameObject : MonoBehaviour
{
    public GameObject targetGameObject;
    public MonoBehaviour scriptToToggle;

    private bool scriptEnabled = true;

    private void Start()
    {

    }

    [NaughtyAttributes.Button]
    public void ToggleTargetScript()
    {
        if (MainManager.Instance.CRTEffect == false) MainManager.Instance.CRTEffect = true;
        else if (MainManager.Instance.CRTEffect == true) MainManager.Instance.CRTEffect = false;

        if (targetGameObject != null && scriptToToggle != null)
        {
            scriptEnabled = !scriptEnabled;
            scriptToToggle.enabled = scriptEnabled;
        }
    }
}