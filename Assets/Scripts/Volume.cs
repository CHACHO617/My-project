using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; // This is needed for working with Audio Mixer

public class VolumeControl : MonoBehaviour
{
    public AudioMixer audioMixer; // Reference to the Audio Mixer

    // Method to set the volume using a slider
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", Mathf.Log10(volume) * 20); // Convert the slider value to decibels
    }
}

