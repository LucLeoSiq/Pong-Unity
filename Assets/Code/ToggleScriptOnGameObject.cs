using UnityEngine;

public class ToggleScriptOnGameObject : MonoBehaviour
{
    public GameObject targetGameObject;
    public MonoBehaviour scriptToToggle;

    private bool scriptEnabled = true;

    [NaughtyAttributes.Button]
    public void ToggleTargetScript()
    {
        if (targetGameObject != null && scriptToToggle != null)
        {
            scriptEnabled = !scriptEnabled;
            scriptToToggle.enabled = scriptEnabled;
        }
    }
}