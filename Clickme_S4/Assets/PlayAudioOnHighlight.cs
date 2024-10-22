using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayAudioOnHighligt : MonoBehaviour
{
    public AudioSource audioSource; // Assign an AudioSource component
    public AudioClip highlightClip; // Assign the audio clip you want to play

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Play the audio clip when the UI element is highlighted
        if (audioSource != null && highlightClip != null)
        {
            audioSource.PlayOneShot(highlightClip);
        }
    }
}
