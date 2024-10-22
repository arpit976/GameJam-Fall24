using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayAudioOnClick : MonoBehaviour, IPointerClickHandler
{
    public AudioSource audioSource;
    public AudioClip audioClip;

    public void OnPointerClick(PointerEventData eventData)
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
