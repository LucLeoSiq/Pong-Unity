using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    [SerializeField] private AudioClip boundaryBounceSFX;
    [SerializeField] private AudioClip paddleBounceSFX;
    [SerializeField] private AudioClip scoreSFX;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        CheckMute();
    }

    [NaughtyAttributes.Button]
    public void playBoundaryBounceSFX()
    {
        audioSource.PlayOneShot(boundaryBounceSFX);
    }
    public void playPaddleBounceSFX()
    {
        audioSource.PlayOneShot(paddleBounceSFX);
    }
    public void playScoreSFX()
    {
        audioSource.PlayOneShot(scoreSFX);
    }

    public void CheckMute()
    {
        if (MainManager.Instance.MuteGame == true) ToggleMute();
    }

    [NaughtyAttributes.Button]
    public void ToggleMute()
    {
        if (audioSource.mute == false) audioSource.mute = true;
        else if (audioSource.mute == true) audioSource.mute = false;
    }
}

