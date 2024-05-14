using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBouncing : MonoBehaviour
{
    [SerializeField] private AudioClip bounceClip;

    AudioSource audioSource;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void BallBounce()
    {
        audioSource.PlayOneShot(bounceClip);
    }
}
