using UnityEngine;
using UnityEngine.UI;

public class MuteToggle : MonoBehaviour
{
    public Toggle toggle;

    private void Start()
    {
        // Load the mute state from PlayerPrefs (0 means unmuted, 1 means muted)        
        int muteState = PlayerPrefs.GetInt("MuteState", 0);
        toggle.isOn = muteState == 1;

        // Set the initial mute state based on the loaded value
        AudioListener.pause = toggle.isOn;
    }

    public void OnToggleValueChanged()
    {
        AudioListener.pause = toggle.isOn;
        PlayerPrefs.SetInt("MuteState", toggle.isOn ? 1 : 0);
        PlayerPrefs.Save();
    }
}
