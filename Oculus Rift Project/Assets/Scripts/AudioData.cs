using UnityEngine;
using System;

[Serializable]
public class AudioData
{
    [SerializeField]
    private string name;

    [SerializeField]
    private AudioClip audioClip;

    public string Name => name;
    public AudioClip AudioClip => audioClip;
}
