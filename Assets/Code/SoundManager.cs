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
}

