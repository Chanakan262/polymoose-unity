using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip clip;

    public void PlayVoice()
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
}
