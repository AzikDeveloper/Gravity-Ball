using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup : MonoBehaviour
{
    public AudioSource bg_audio;
    private void Awake()
    {
        bg_audio.Play();
    }
}
