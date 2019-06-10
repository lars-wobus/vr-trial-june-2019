using UnityEngine;
using System;

[Serializable]
public class AudioData
{
    [SerializeField]
    private string name;

    [SerializeField]
    private AudioSource audioSource;

    public string Name => name;
    public AudioSource AudioSource => audioSource;
}
