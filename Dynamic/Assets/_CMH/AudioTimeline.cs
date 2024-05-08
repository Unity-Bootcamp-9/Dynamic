using System;
using UnityEngine;

public class AudioTimeline : MonoBehaviour
{
    [Range(0f, 60f * 4)] public float startTime = 0f;

    private AudioSource _audio;

    private void Start()
    {
        _audio = GetComponent<AudioSource>();

        _audio.time = startTime;
    }
}
