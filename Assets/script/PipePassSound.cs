using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePassSound : MonoBehaviour
{
    public AudioClip musicClip;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = musicClip;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Verifica se o pássaro passou pelo cano
        {
            audioSource.Play();
        }
    }
}
